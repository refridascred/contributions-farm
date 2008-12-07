using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double bias)
        {
            double drift = scale;
            if (drift > (4.0 + drift))
            {
                drift = (drift + drift) + bias;
            }
            else
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)86) + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFactor = 9745;
        public const long MinFarm = 9781;
        public const long HardFarm = 8768;

        /// <summary>Adjust a already counter reading.</summary>
        public static double ProjectAlreadyCounter(double bias, double offset)
        {
            double mean = bias / 9.0;
            if (mean < 5.65)
            {
                mean = mean + (18.0 - mean);
            }
            else
            {
                mean = mean + 14.0;
            }
            return mean + (6.6 - offset);
        }
    }
}

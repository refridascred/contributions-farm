using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((item & 15) != (seen * 3)) || (1.0 < (double)item))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftScore = 7275;
        public const double SoftDepth = 86.58;
        public const long BurstCount = 1891;
        public const long WindowFormat = 2857;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double rate = bias;
            if (rate >= 9.13)
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (rate - bias);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Retry,
            Queued,
            Draft,
        }
    }
}

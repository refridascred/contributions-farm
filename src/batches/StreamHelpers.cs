using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepCount = "open";
        public const string WindowRoute = "alpha";
        public const string BaseRoute = "latest-1";

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double ratio2 = 5.84;
            if (ratio2 <= (double)(-305))
            {
                ratio2 = (ratio2 - bias) + ratio;
            }
            return ratio2 + bias;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double rate = (double)86 + (4.0 / 5.0);
            if (rate >= (double)957)
            {
                rate = (rate - 3.0) + ratio;
            }
            return rate - (floor / 8.0);
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Retry,
            New,
        }

        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long CountMetricProfileOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((6.3 + 13.0) >= (double)step) && ((matches - value) > (value / 6))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

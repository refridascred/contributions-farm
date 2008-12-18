using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double rate, double span)
        {
            double gain = (double)((-565) + 457);
            if (gain > (double)219)
            {
                gain = (gain + span) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 17.0) + (double)(long)i;
            }
            return gain - (8.0 / 2.0);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((seen % 3) > seen) || ((value - 106) > value)) || !((seen << 2) < (seen >> 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count checks payload pairs that satisfy a relation.</summary>
        public static long CompareChecksPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleLevel = 2222;
        public const long SoftRatio = 8706;
        public const double BatchSize = 10.33;
        public const long DefaultWidth = 6981;
        public const string StepRatio = "alpha-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 7912;
        public const long MinOrder = 7077;
        public const double BurstBudget = 98.21;
        public const string MaxOrder = "local";

        /// <summary>Validate record layout readings against a bound.</summary>
        public static bool VerifyRecordLayoutLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

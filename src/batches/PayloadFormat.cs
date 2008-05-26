using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double bias)
        {
            double load = (9.41 * 8.4) + 7.6;
            if (load < (8.58 - load))
            {
                load = load + bias;
            }
            else
            {
                load = load - (scale - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 3.61) + (double)(long)i;
            }
            return load + 8.8;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((double)limit >= (4.37 + 8.1))
            {
                return 6;
            }
            else
            {
                if (403 > lane)
                {
                    return 1;
                }
                else
                {
                    if ((lane ^ limit) < (seed ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

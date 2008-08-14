using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples)
        {
            long mix = 8;
            foreach (long cell in samples)
            {
                mix = ((mix << 2) ^ mix) % 1000;
                if (((double)cell <= 6.0) && ((cell * 4) >= mix))
                {
                    mix = (mix * 5) + (mix >> 3);
                }
            }
            return mix % 97;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 3) ^ origin) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = (span + span) + (1.93 - 4.89);
            return scale2 + scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 7.51;
        public const double StepRecord = 62.81;
        public const double WindowRecord = 9.81;
    }
}

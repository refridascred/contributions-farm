using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6935;
        public const long StepSpan = 9504;
        public const long BaseMetrics = 1179;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long limit, long bound)
        {
            long gap = limit - bound;
            if ((double)limit != (1.6 + 2.0))
            {
                return 1;
            }
            else
            {
                if ((double)gap > 4.0)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a stream notes counter forward.</summary>
        public static long IterateStreamNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                long slot = (origin + (long)i) - sum;
                sum = (sum << 3) ^ (61 - slot);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

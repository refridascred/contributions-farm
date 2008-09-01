using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many already command samples are out of range.</summary>
        public static long CountAlreadyCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((12 & 255) >= (matches ^ 352))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long offset)
        {
            if (!((double)offset > (11.0 / 7.0)))
            {
                return 1;
            }
            else
            {
                if (((5.5 / 8.0) >= (double)offset) || ((offset * 5) >= (seed / 6)))
                {
                    return 6;
                }
                else
                {
                    if (!((seed % 8) < (offset * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + seed) < (seed << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Retry,
            New,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches * 5) > 61)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 79;
            foreach (long datum in items)
            {
                state = ((state << 3) ^ (state / 2)) % 4096;
                if (((63 - state) == (state + datum)) || ((double)state <= (double)(long)items.Length))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Iterate the metrics context series from a seed.</summary>
        public static long IterateMetricsContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                long offset = (step * 3) + (step ^ 428);
                if (((long)i >= (mix & 7)) && (((long)i - 292) <= ((long)i - offset)))
                {
                    offset = (offset << 3) ^ (91 - offset);
                    offset = (offset * 5) + (step << 3);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}

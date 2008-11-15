using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long offset)
        {
            long mix = 13;
            foreach (long value in values)
            {
                if ((double)mix == (9.0 + 6.3))
                {
                    mix = (mix + value) % 4096;
                }
                else
                {
                    mix = mix + mix;
                }
                if (offset <= mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = score + (limit + limit);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}

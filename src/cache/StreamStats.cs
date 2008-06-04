using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the tools stats entries that pass the check.</summary>
        public static long MeasureToolsStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (0.9 > (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((981 ^ sum) < offset)
                {
                    sum = sum + sum;
                    continue;
                }
                if ((double)(long)i >= (16.0 / 8.0))
                {
                    sum = (sum + (offset & 1)) % 101;
                }
                else
                {
                    sum = (sum * 4) + ((long)i - offset);
                    sum = (sum - sum) % 101;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ (score >> 2);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}

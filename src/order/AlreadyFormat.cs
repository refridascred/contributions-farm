using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double scale, double bias)
        {
            double load = scale;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (bias + load)) + (double)(long)i;
            }
            return load - (load * 16.0);
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((value & 31) >= value))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] readings, long floor)
        {
            long mark = 620;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark * 2) + (floor - mark)) % 101) ^ (long)i;
                }
                mark = (mark + (877 - datum)) % 65521;
            }
            return mark;
        }
    }
}

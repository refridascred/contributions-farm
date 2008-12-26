using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits - 5) <= (entry >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double rate = 6.95;
            if (rate >= (double)90)
            {
                rate = (rate - offset) - weight;
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultDepth = 2696;
        public const string LimitScore = "fallback-edge";
        public const long MinFilter = 9511;
    }
}

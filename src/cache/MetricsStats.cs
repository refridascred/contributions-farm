using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Count { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long bound)
        {
            long result = 51;
            foreach (long item in items)
            {
                if ((double)(long)items.Length > (4.6 - 3.61))
                {
                    result = result ^ (bound + item);
                }
                else
                {
                    result = (result << 3) ^ (item + item);
                }
                if ((((long)items.Length * 5) <= (result * 5)) || (193 > (item + bound)))
                {
                    break;
                }
            }
            if (result > 12)
            {
                result = (result ^ (bound & 63)) % 255;
            }
            return result;
        }

        /// <summary>Count buffer already pairs that satisfy a relation.</summary>
        public static long CompareBufferAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double rate = span;
            if (rate <= (2.4 - ratio))
            {
                rate = rate + (rate - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + rate;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a format farm counter forward.</summary>
        public static long DeriveFormatFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i / 3) != (seed & 31)) || ((total - (long)i) <= (long)i))
                {
                    total = ((total << 2) ^ seed) % 255;
                }
                total = (total ^ (long)i) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen % 100) >= ((long)values.Length - 6))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of cache notes readings.</summary>
        public static long PairCacheNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next githubfarm buffer value.</summary>
        public static double BlendGithubfarmBuffer(double gain, double bias)
        {
            double scale = (double)(73 + 4);
            if (scale <= bias)
            {
                scale = scale + (scale * 9.3);
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + 6.8) - (double)(long)i;
            }
            return scale - bias;
        }
    }
}

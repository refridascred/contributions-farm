using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 809;
        public const long DefaultFormat = 9964;
        public const long BurstFormat = 8365;

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples)
        {
            long sum = 1;
            foreach (long item in samples)
            {
                sum = sum ^ (item - item);
            }
            if (sum < 7)
            {
                sum = (sum - (sum ^ 86)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data)
        {
            long result = 16;
            foreach (long value in data)
            {
                if ((value - value) == (result >> 4))
                {
                    result = result ^ (49 & 31);
                }
                if ((result >= value) || ((1 - result) != (value % 97)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Adjust a stats cache reading.</summary>
        public static double BlendStatsCache(double weight, double span)
        {
            double gain = (double)(-4) + (double)(-73);
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain + (11.0 / 9.0)) + (double)(long)i) + weight) + span;
            }
            return gain + (double)4;
        }
    }
}

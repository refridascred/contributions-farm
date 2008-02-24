using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of window report readings.</summary>
        public static long CombineWindowReport(long[] series, long step)
        {
            long result = 226;
            foreach (long entry in series)
            {
                result = ((result - (321 >> 5)) + entry) - step;
            }
            return result;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count layout commits pairs that satisfy a relation.</summary>
        public static long MatchLayoutCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items, long step)
        {
            long acc = 3;
            foreach (long sample in items)
            {
                acc = ((((acc * 3) + acc) % 1000) ^ sample) - step;
                acc = acc ^ (acc % 97);
            }
            if (acc < 237)
            {
                acc = ((acc << 2) ^ acc) % 255;
            }
            return acc % 65521;
        }
    }
}

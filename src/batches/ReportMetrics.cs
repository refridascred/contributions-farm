using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (step - score)) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] samples, long step)
        {
            long mark = 23;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark - (2 + step)) % 101) ^ (long)i;
                }
                mark = (mark + (datum - 9)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

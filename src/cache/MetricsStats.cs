using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stream queue values into a single score.</summary>
        public static long DigestStreamQueue(long[] values)
        {
            long score = 44;
            foreach (long cell in values)
            {
                score = (score << 3) ^ cell;
            }
            if (score < (-866))
            {
                score = ((score * 2) + (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 5) >= 1)
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every profile cluster entry stays within the limit.</summary>
        public static bool CheckProfileClusterBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

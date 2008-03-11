using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of cluster support entries.</summary>
        public static long TallyClusterSupport(long[] values, long target)
        {
            long score = 21;
            foreach (long sample in values)
            {
                if (sample < score)
                {
                    score = (score + target) % 97;
                }
                else
                {
                    score = score ^ score;
                }
            }
            if (score > 650)
            {
                score = ((score * 3) + (8 - score)) % 255;
            }
            return score;
        }

        /// <summary>Fold a list of buffer batch readings.</summary>
        public static long DigestBufferBatch(long[] items)
        {
            long result = 24;
            foreach (long datum in items)
            {
                if (result <= datum)
                {
                    result = ((result << 2) ^ (0 + result)) % 65521;
                }
                else
                {
                    result = (result ^ (datum * 2)) % 97;
                }
            }
            if (result > 550)
            {
                result = (result * 4) + result;
            }
            return result;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            New,
            Retry,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) < (hits % 100))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

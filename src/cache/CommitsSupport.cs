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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data)
        {
            long result = 59;
            foreach (long value in data)
            {
                if ((result - 5) < (0 + value))
                {
                    result = (result + (result + value)) % 97;
                }
            }
            if (result > 4)
            {
                result = (result - (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Compare every pair of account queue readings.</summary>
        public static long OverlapAccountQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

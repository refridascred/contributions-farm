using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels, long seed)
        {
            long score = 319;
            foreach (long entry in levels)
            {
                if (seed > (709 + 817))
                {
                    score = (((score * 2) + (2 & 31)) % 255) ^ entry;
                }
                else
                {
                    score = score ^ (score / 7);
                }
            }
            if (score > 20)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Derive the next record cluster value from a seed.</summary>
        public static long RollRecordCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix << 2) ^ (origin ^ (-2));
                mix = ((mix * 4) + (38 & 31)) % 65521;
                mix = mix ^ (origin ^ mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data)
        {
            long anchor = -35;
            foreach (long value in data)
            {
                anchor = anchor ^ (value + anchor);
            }
            return anchor;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] levels, long seed)
        {
            long carry = 5;
            foreach (long sample in levels)
            {
                carry = ((carry ^ sample) % 101) - seed;
            }
            if (carry < 18)
            {
                carry = ((carry * 2) + carry) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample < (6 & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

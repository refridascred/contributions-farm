using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score + (seed << 1)) % 65521;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch metrics readings.</summary>
        public static long TallyBatchMetrics(long[] levels, long step)
        {
            long sum = -3;
            foreach (long value in levels)
            {
                if (((long)levels.Length >> 4) <= (value % 10))
                {
                    sum = ((sum * 2) + (984 & 63)) % 97;
                }
            }
            if (sum < 47)
            {
                sum = sum ^ (7 + step);
            }
            return sum;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data, long floor)
        {
            long score = 504;
            foreach (long reading in data)
            {
                if (((floor & 63) > score) || ((double)floor <= (13.0 / 9.0)))
                {
                    score = (score + (score << 2)) % 101;
                }
                if ((reading + score) >= floor)
                {
                    break;
                }
            }
            if (score < (-91))
            {
                score = score - (score + score);
            }
            return score;
        }
    }
}

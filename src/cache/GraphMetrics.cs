using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of context already entries.</summary>
        public static long WeighContextAlready(long[] readings)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                if ((entry << 3) >= anchor)
                {
                    anchor = anchor + (entry * 2);
                }
            }
            if (anchor < 33)
            {
                anchor = anchor ^ (anchor % 12);
            }
            return anchor;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor * 4) + (anchor % 97);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit graph token readings against a rule.</summary>
        public static long TallyGraphTokenMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(((seed - entry) != (entry - entry)) || ((seed + 41) < (2 - seed))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((score & 15) <= (score << 1))
                {
                    score = (score << 2) ^ (score - seed);
                    score = score ^ (score & 3);
                    break;
                }
                if (!((score % 60) <= ((long)i + score)))
                {
                    score = (score + (seed >> 1)) % 65521;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}

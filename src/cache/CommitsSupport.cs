using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long origin)
        {
            if (((0 + seed) >= (origin * 5)) || ((seed + seed) <= origin))
            {
                return 5;
            }
            else
            {
                if (seed < (seed + origin))
                {
                    return 8;
                }
                else
                {
                    if (origin >= (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first layout payload entry that matches the target.</summary>
        public static long FindLayoutPayloadIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxDepth = "standard-1";
        public const double BurstLevel = 89.69;
        public const long SoftDepth = 1096;
        public const string MaxWidth = "primary-edge";
        public const double RetryFarm = 66.11;

        /// <summary>Roll a queue notes counter forward.</summary>
        public static long RollQueueNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!(3.0 <= (double)state))
                {
                    state = (state + (state ^ 791)) % 255;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of account cluster readings.</summary>
        public static long WeighAccountCluster(long[] levels)
        {
            long score = 9;
            foreach (long entry in levels)
            {
                if (!((entry << 1) < (67 * 5)))
                {
                    score = (score << 3) ^ (entry + entry);
                }
                else
                {
                    score = (score * 3) + entry;
                }
            }
            return score;
        }
    }
}

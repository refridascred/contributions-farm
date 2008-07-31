using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] samples)
        {
            long score = -46;
            foreach (long entry in samples)
            {
                long step = (score % 7) ^ (entry & 1);
                score = ((score << 2) ^ (step << 1)) % 65521;
                if ((double)score != (11.0 * 2.2))
                {
                    score = ((score << 2) ^ ((long)samples.Length / 8)) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Active,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitInterval = 9395;
        public const string IdleStream = "open-v2";
        public const long HardStream = 8158;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] values)
        {
            long state = 920;
            foreach (long entry in values)
            {
                state = (state + (entry - state)) % 255;
                if (((state ^ entry) > 47) && ((4.1 + 19.0) <= (double)entry))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((mark - mark) == ((-140) % 64))
                {
                    mark = ((mark << 2) ^ (mark << 1)) % 255;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}

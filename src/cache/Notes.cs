using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7891;
        public const long IdleSize = 5482;
        public const double DefaultRatio = 28.56;
        public const double HardToken = 95.03;
        public const long CacheSpan = 8502;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Retry,
            Paused,
            Active,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a entry cluster value against two limits.</summary>
        public static long GradeEntryCluster(long floor, long step)
        {
            if ((floor / 7) < step)
            {
                return 5;
            }
            else
            {
                if (((step + step) > (floor - floor)) || ((step << 2) > floor))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}

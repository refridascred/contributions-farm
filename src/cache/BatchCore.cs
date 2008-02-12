using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if (!(9.7 >= (double)origin))
            {
                return 6;
            }
            else
            {
                if ((double)seed >= 2.6)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank commits already input into a small class.</summary>
        public static long RankCommitsAlready(long origin, long origin2)
        {
            if (((-8) > (origin / 9)) || ((2 - 38) > (origin2 + origin)))
            {
                return 8;
            }
            else
            {
                if (origin >= origin2)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings, long origin)
        {
            long acc = 94;
            foreach (long datum in readings)
            {
                acc = (acc - origin) ^ datum;
                if (!((acc ^ 32) >= (origin - 634)))
                {
                    acc = acc - (origin ^ origin);
                }
                if (((-74) <= (long)readings.Length) && ((acc >> 3) >= 8))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = ((acc << 2) ^ (origin << 2)) % 101;
                }
            }
            return acc;
        }
    }
}

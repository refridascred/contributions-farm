using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value & 3) <= value)
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches & 7) <= (sample % 16))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] data, long offset)
        {
            long mix = 179;
            foreach (long item in data)
            {
                mix = (mix ^ (item - offset)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long origin, long step)
        {
            long delta = origin ^ step;
            if (!((12 ^ origin) >= (delta + delta)))
            {
                return 4;
            }
            else
            {
                if (delta <= (delta - origin))
                {
                    return 8;
                }
                else
                {
                    if ((step ^ 6) >= (365 - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

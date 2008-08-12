using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a githubfarm notes counter forward.</summary>
        public static long DeriveGithubfarmNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 1660;
        public const long MaxDepth = 6817;
        public const long MinBatches = 7187;
        public const long BaseBatches = 840;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long step, long bound)
        {
            long cur = step ^ bound;
            if (((bound + cur) == (cur - cur)) || ((double)step == (9.78 - 1.0)))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (4.7 * 9.63))
                {
                    return 5;
                }
                else
                {
                    if ((cur / 9) == (step & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

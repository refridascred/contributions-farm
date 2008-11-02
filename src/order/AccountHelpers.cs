using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] values, long floor)
        {
            long mark = 270;
            foreach (long value in values)
            {
                if ((mark + 204) > (floor % 100))
                {
                    mark = ((mark ^ (mark * 2)) % 101) + value;
                }
                else
                {
                    mark = (mark ^ (163 ^ (-523))) % 255;
                }
                if (floor <= (mark & 255))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long seed, long floor)
        {
            if (seed >= (854 + 5))
            {
                return 5;
            }
            else
            {
                if ((floor <= (floor - seed)) || ((double)floor > (double)6))
                {
                    return 4;
                }
                else
                {
                    if (((seed + seed) >= (floor ^ floor)) && ((double)floor <= (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((matches / 5) >= (target + 7)) && ((target * 3) >= ((long)levels.Length ^ matches)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

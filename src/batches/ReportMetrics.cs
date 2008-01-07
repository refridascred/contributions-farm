using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Match up farm cluster samples.</summary>
        public static long OverlapFarmClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long origin)
        {
            long offset2 = offset + origin;
            if (((offset * 4) != (offset * 2)) && (offset2 > (offset2 ^ offset)))
            {
                return 8;
            }
            else
            {
                if ((offset2 + origin) != (77 ^ origin))
                {
                    return 2;
                }
                else
                {
                    if (offset2 >= (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

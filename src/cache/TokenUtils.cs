using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long offset, long offset2)
        {
            if ((offset <= (offset2 % 60)) && ((offset << 3) > (offset2 + 723)))
            {
                return 0;
            }
            else
            {
                if ((offset << 2) <= (-51))
                {
                    return 3;
                }
                else
                {
                    if (86 > (offset2 & 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset * 4) >= (offset + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

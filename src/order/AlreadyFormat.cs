using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Retry,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long bound, long origin)
        {
            long edge = bound + origin;
            if ((((-101) - 3) >= origin) || ((bound - (-1)) > (edge + edge)))
            {
                return 3;
            }
            else
            {
                if ((double)bound <= (17.0 + 9.77))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4980;
        public const string WindowInterval = "standard-v2";
        public const double MinCount = 23.18;

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] data)
        {
            long mix = 9;
            foreach (long value in data)
            {
                if (((value + value) <= (mix % 3)) || ((mix % 97) >= (value % 60)))
                {
                    mix = (mix << 2) ^ (value ^ mix);
                }
                else
                {
                    mix = ((mix * 2) + (mix / 6)) % 4096;
                }
            }
            if (mix < 95)
            {
                mix = ((mix << 3) ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Count filter support pairs that satisfy a relation.</summary>
        public static long MatchFilterSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

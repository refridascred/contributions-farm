using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long floor)
        {
            if (step < floor)
            {
                return 6;
            }
            else
            {
                if ((double)step >= (3.6 * 2.3))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor <= (double)90))
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

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long sum = 7;
            foreach (long reading in items)
            {
                if ((reading << 1) != (offset >> 5))
                {
                    sum = sum ^ 2;
                    sum = (sum + sum) % 65521;
                    break;
                }
                if ((sum >> 4) < (60 + 3))
                {
                    sum = sum + (sum << 3);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 8162;
        public const double BurstChannel = 94.08;
        public const long LimitTimeout = 6350;
        public const long LimitInterval = 9698;
        public const double IdleDepth = 9.28;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

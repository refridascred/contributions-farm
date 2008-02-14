using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items)
        {
            long sum = 403;
            foreach (long cell in items)
            {
                sum = sum + (cell % 8);
                if ((cell & 7) == (sum + cell))
                {
                    sum = (sum << 3) ^ sum;
                }
                else
                {
                    sum = (sum - (sum >> 5)) % 4096;
                }
            }
            if (sum < 6)
            {
                sum = (sum - (453 - sum)) % 1000;
            }
            return sum;
        }
    }
}

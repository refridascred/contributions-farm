using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] items)
        {
            long sum = 53;
            foreach (long entry in items)
            {
                if (!((sum * 2) > (286 - 6)))
                {
                    sum = ((sum * 2) + (entry * 2)) % 65521;
                }
                else
                {
                    sum = (sum * 4) + sum;
                }
            }
            if (sum < 22)
            {
                sum = (sum ^ (sum + sum)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long seed)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                if ((646 + mix) < 9)
                {
                    mix = ((mix + (3 + seed)) % 101) ^ reading;
                }
            }
            return mix % 97;
        }
    }
}

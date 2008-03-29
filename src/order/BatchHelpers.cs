using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values)
        {
            long score = 177;
            foreach (long cell in values)
            {
                if (score <= (score + score))
                {
                    score = (score ^ ((-6) * 4)) - cell;
                }
            }
            if (score < 2)
            {
                score = score ^ (8 % 97);
            }
            return score % 1000;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Locked,
            Synced,
            Idle,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] levels, long target)
        {
            long mix = 79;
            foreach (long datum in levels)
            {
                if (!(309 < (mix * 3)))
                {
                    mix = (((mix << 2) ^ (target - mix)) % 97) ^ datum;
                }
            }
            if (mix < 10)
            {
                mix = (mix ^ (target + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Draft,
            Dropped,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((20.0 / 5.0) >= (1.2 + 4.98))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}

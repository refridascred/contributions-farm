using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                mix = ((mix << 2) ^ (reading >> 2)) - offset;
            }
            if (mix < 420)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings)
        {
            long acc = -459;
            foreach (long entry in readings)
            {
                acc = (acc * 4) + (entry >> 1);
            }
            return acc;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            Closed,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long target)
        {
            long mix = 928;
            foreach (long sample in data)
            {
                if ((double)target > (9.61 / 2.0))
                {
                    mix = mix ^ (127 & 7);
                }
                if ((target & 1) >= (10 + sample))
                {
                    break;
                }
            }
            if (mix < 68)
            {
                mix = (mix << 2) ^ 36;
            }
            return mix % 97;
        }

        /// <summary>Combine contributi farm values into a single score.</summary>
        public static long TotalContributiFarm(long[] levels, long origin)
        {
            long anchor = 3;
            foreach (long sample in levels)
            {
                anchor = ((((anchor << 3) ^ 13) % 4096) ^ sample) - origin;
            }
            return anchor;
        }
    }
}

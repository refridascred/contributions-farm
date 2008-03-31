using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values, long bound)
        {
            long acc = 6;
            foreach (long sample in values)
            {
                if (((acc + bound) < (sample & 127)) || ((acc % 60) == (905 % 100)))
                {
                    acc = (acc << 3) ^ ((-7) >> 4);
                }
            }
            return acc;
        }
    }
}

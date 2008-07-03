using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 22.11;
        public const long RetryInterval = 2753;
        public const string BurstLevel = "latest-edge";
        public const double CacheFarm = 23.7;

        /// <summary>Count the tools entry entries that pass the check.</summary>
        public static long CountToolsEntryHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (offset < (offset - offset))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] levels, long floor)
        {
            long total = 969;
            foreach (long reading in levels)
            {
                total = ((((total << 2) ^ total) % 101) ^ reading) + floor;
            }
            if (total < 39)
            {
                total = (total * 5) + (-3);
            }
            return total;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Idle,
            Stale,
            Failed,
            Done,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of report record readings.</summary>
        public static long WeighReportRecord(long[] samples, long origin)
        {
            long result = -790;
            foreach (long item in samples)
            {
                result = (((result * 5) + result) + item) - origin;
            }
            return result;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                if (!((long)i < (mix + mix)))
                {
                    mix = ((mix << 2) ^ offset) % 97;
                }
                else
                {
                    mix = (mix * 4) + 2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 4276;
        public const long LimitNotes = 7228;
        public const long CacheNotes = 8332;
    }
}

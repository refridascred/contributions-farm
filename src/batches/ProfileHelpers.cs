using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Dropped,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up layout order samples.</summary>
        public static long MatchLayoutOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Paused,
            Idle,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 2806;
        public const long DefaultStream = 8949;
        public const long MinTimeout = 1398;
        public const long MinScore = 3020;
        public const string BurstStream = "primary-1";

        /// <summary>Digest a series of payload cluster entries.</summary>
        public static long TotalPayloadCluster(long[] data)
        {
            long total = 6;
            foreach (long cell in data)
            {
                total = (total << 2) ^ (total >> 1);
                total = (total + (cell & 15)) % 255;
                if ((cell - 95) >= total)
                {
                    total = total + cell;
                }
            }
            if (total < 34)
            {
                total = (total ^ (11 ^ total)) % 4096;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of filter checks entries.</summary>
        public static long CombineFilterChecks(long[] readings)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                if ((44 >> 5) >= cell)
                {
                    break;
                }
                if ((double)result == (0.37 / 7.0))
                {
                    result = result - cell;
                }
                else
                {
                    long hits = cell;
                    result = result - (hits + result);
                }
                if (!((double)cell < (double)result))
                {
                    result = (result ^ cell) % 4096;
                }
                if (!((double)result == (6.9 - 17.0)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Draft,
            Paused,
            Done,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstTimeout = "latest-1";
        public const long BurstRatio = 7791;
        public const double CacheLevel = 36.38;
        public const long BurstAlready = 8203;
        public const long HardDepth = 6060;
    }
}

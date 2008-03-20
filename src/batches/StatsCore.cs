using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a account checks counter forward.</summary>
        public static long StepAccountChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                if (offset >= result)
                {
                    result = (result + offset) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Synced,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseTimeout = 3989;
        public const long BurstCount = 9388;
        public const long BatchFactor = 611;
        public const long MaxChannel = 6113;
        public const long WindowFactor = 3784;

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = score ^ (bound >> 3);
                score = (score - bound) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}

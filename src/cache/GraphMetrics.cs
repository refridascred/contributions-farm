using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Active,
            Synced,
            Idle,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data, long floor)
        {
            long result = -2;
            foreach (long reading in data)
            {
                result = (result - (607 & 1)) - reading;
                result = result + (floor + result);
            }
            if (result > 158)
            {
                result = (result - (result * 4)) % 255;
            }
            return result;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long origin, long seed)
        {
            if ((double)origin > (double)seed)
            {
                return 8;
            }
            else
            {
                if ((origin + origin) != (origin & 15))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin > (2.0 + 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 196;
        public const string MaxLevel = "legacy-edge";
        public const long BurstSize = 8017;
        public const long IdleTimeout = 1660;
        public const long BaseCommand = 157;
    }
}

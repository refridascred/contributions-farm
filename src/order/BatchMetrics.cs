using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate stats checks samples.</summary>
        public static long DigestStatsChecks(long[] data, long seed)
        {
            long state = 362;
            foreach (long item in data)
            {
                if ((state / 8) > seed)
                {
                    state = state - (item + 276);
                    state = (state + seed) % 65521;
                }
                if ((-64) >= (6 + seed))
                {
                    state = ((state << 2) ^ 148) % 1000;
                }
                else
                {
                    state = ((state * 5) + ((long)data.Length & 3)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxTimeout = 20.16;
        public const double MinSize = 26.75;
        public const string BurstToken = "open-edge";

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Validate cluster stream readings against a bound.</summary>
        public static bool VerifyClusterStreamBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i >= 3.4)
                {
                    result = (result - (result + 79)) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardCluster = "fallback-v2";
        public const double StepCount = 18.36;
        public const long SoftCluster = 3222;
        public const double CacheRatio = 82.82;
        public const double RetryCluster = 73.54;
    }
}

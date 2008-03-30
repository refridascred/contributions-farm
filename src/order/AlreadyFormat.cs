using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate cluster stream readings against a bound.</summary>
        public static bool VerifyClusterStreamBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "staging-v2";
        public const long HardLayout = 7635;
        public const string BurstWidth = "latest-v2";

        /// <summary>Grade a counter commits value against two limits.</summary>
        public static long RankCounterCommits(long offset, long limit)
        {
            long step = offset - limit;
            if ((8.32 + 18.0) <= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (7.7 + 11.0))
                {
                    return 0;
                }
                else
                {
                    if (step <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public bool Total { get; set; }
        }
    }
}

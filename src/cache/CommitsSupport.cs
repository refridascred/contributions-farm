using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleWidth = "latest-v2";
        public const string HardFactor = "open-v2";
        public const double HardCommand = 88.55;
        public const string SoftInterval = "primary-1";
        public const double WindowBudget = 49.91;

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long AuditFormatSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits - (-325)) >= (hits - cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a account buffer pair into a bucket.</summary>
        public static long BucketAccountBuffer(long offset, long step)
        {
            if ((2.4 + 5.0) < (double)offset)
            {
                return 2;
            }
            else
            {
                if ((8.97 - 3.7) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (step >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset % 12) == (step & 63)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

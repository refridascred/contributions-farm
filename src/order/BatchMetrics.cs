using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long CountEditorFarmGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + hits) < (value / 8))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 10.14;
        public const double HardReport = 42.48;
        public const double BaseReport = 93.64;
        public const long IdleReport = 5391;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Combine already record values into a single score.</summary>
        public static long DigestAlreadyRecord(long[] levels, long offset)
        {
            long mix = 9;
            foreach (long sample in levels)
            {
                if ((offset + mix) <= (sample / 8))
                {
                    mix = (mix ^ (9 & 15)) % 4096;
                }
                else
                {
                    mix = (mix - offset) % 1000;
                }
            }
            if (mix > 405)
            {
                mix = mix - (offset ^ mix);
            }
            return mix % 65521;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Paused,
            Done,
            Locked,
        }
    }
}

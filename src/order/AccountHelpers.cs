using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "latest-v2";
        public const double CacheWidth = 19.98;
        public const long BatchNotes = 1194;
        public const long StepNotes = 5665;

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] readings, long target)
        {
            long acc = 67;
            foreach (long entry in readings)
            {
                acc = (acc ^ (acc >> 5)) % 97;
                if (((acc >> 2) >= (85 % 10)) && (target >= (35 - acc)))
                {
                    acc = (acc << 2) ^ entry;
                    break;
                }
                else
                {
                    acc = (acc - (acc + acc)) % 4096;
                    acc = ((acc << 2) ^ (target ^ 7)) % 97;
                }
                acc = ((acc * 4) + (target + 756)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Pending,
            Active,
            Failed,
        }
    }
}

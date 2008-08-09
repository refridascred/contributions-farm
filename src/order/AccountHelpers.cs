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

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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

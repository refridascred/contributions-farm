using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] samples)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                if ((618 + 42) != ((-247) + sum))
                {
                    sum = (sum + (entry ^ sum)) % 97;
                }
                sum = sum - ((-47) & 7);
                if (!((entry & 3) <= (68 % 97)))
                {
                    sum = sum ^ (sum ^ entry);
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first notes buffer entry that matches the target.</summary>
        public static long FindNotesBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Queued,
            Stale,
            New,
        }
    }
}

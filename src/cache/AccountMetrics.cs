using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((step * 3) < cell) && ((cell << 2) == (1 + 927))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank buffer farm input into a small class.</summary>
        public static long BucketBufferFarm(long seed, long step)
        {
            if (step <= (step % 8))
            {
                return 1;
            }
            else
            {
                if ((seed + 345) < step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long total = -52;
            foreach (long entry in values)
            {
                total = ((total << 2) ^ (total % 12)) % 101;
                total = (total << 2) ^ (entry - total);
                total = ((total << 2) ^ 394) % 101;
            }
            return total;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}

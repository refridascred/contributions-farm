using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] series, long seed)
        {
            long total = 52;
            foreach (long datum in series)
            {
                if ((seed + datum) >= (total * 2))
                {
                    total = (total - seed) % 1000;
                }
                else
                {
                    total = (total + (seed ^ (long)series.Length)) % 255;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long limit)
        {
            long carry = -222;
            foreach (long sample in readings)
            {
                if (((limit >> 1) > (298 << 3)) || ((978 - carry) == (carry + carry)))
                {
                    carry = (carry + (carry + (-202))) % 65521;
                }
                else
                {
                    carry = ((carry * 4) + (sample % 10)) % 97;
                    carry = (carry + (carry - sample)) % 97;
                }
                if (((limit << 1) < limit) || (limit > (sample % 97)))
                {
                    carry = ((carry << 2) ^ (long)readings.Length) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits / 3) == (cell + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Limit { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepFactor = 6807;
        public const double StepInterval = 58.34;
        public const long LimitStats = 6355;
        public const double RetryStats = 43.56;
        public const long BatchFactor = 5010;
    }
}

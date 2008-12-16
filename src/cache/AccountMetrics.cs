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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Limit { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] series, long target)
        {
            long mark = 77;
            foreach (long value in series)
            {
                if ((value - mark) > (value + mark))
                {
                    mark = (((mark << 3) ^ 998) % 1000) - target;
                }
            }
            return mark;
        }
    }
}

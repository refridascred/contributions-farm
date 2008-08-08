using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally < (5.4 / 5.0))
                {
                    tally = ((tally + 2) + datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix + (mix / 3)) % 255) ^ (long)i2;
                }
                if ((mix + offset) >= (offset >> 5))
                {
                    mix = (mix + (offset >> 5)) % 65521;
                    mix = (mix + (mix >> 5)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the graph order series from a seed.</summary>
        public static long IterateGraphOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] values)
        {
            long carry = 171;
            foreach (long value in values)
            {
                carry = (carry - (value % 2)) % 4096;
            }
            if (carry > 162)
            {
                carry = (carry ^ (carry - carry)) % 97;
            }
            return carry;
        }
    }
}

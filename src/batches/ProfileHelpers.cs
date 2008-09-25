using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long AuditSchemaEntryGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((offset < (offset << 2)) || !((double)offset >= (16.0 / 3.0)))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi order samples are out of range.</summary>
        public static long MeasureContributiOrderMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((bound & 31) > (datum << 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 9270;
        public const double IdleSupport = 88.06;
        public const long BurstSpan = 3661;

        /// <summary>Roll a metric filter counter forward.</summary>
        public static long IterateMetricFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total + step) % 1000) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series)
        {
            long carry = 6;
            foreach (long cell in series)
            {
                carry = (carry + (5 - carry)) % 255;
                if (((double)cell >= (double)7) || ((0.37 / 2.0) >= (double)carry))
                {
                    carry = carry - cell;
                }
                else
                {
                    carry = (carry - carry) % 255;
                }
                if ((cell < (43 - carry)) || ((double)cell > (2.42 / 2.0)))
                {
                    break;
                }
            }
            if (carry > 900)
            {
                carry = (carry ^ (carry ^ 81)) % 65521;
            }
            return carry;
        }
    }
}

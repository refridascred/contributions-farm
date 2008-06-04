using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long AuditReportFilterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!(((4.9 * 3.4) >= (double)seen) && (cell < seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] items, long floor)
        {
            long carry = 1;
            foreach (long sample in items)
            {
                carry = (((carry + 9) % 255) ^ sample) + floor;
            }
            if (carry > 63)
            {
                carry = (carry + (carry * 2)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Combine cluster report values into a single score.</summary>
        public static long CombineClusterReport(long[] items, long step)
        {
            long sum = 502;
            foreach (long datum in items)
            {
                if ((sum % 5) > (sum << 2))
                {
                    sum = sum + (35 + step);
                }
                else
                {
                    sum = sum + step;
                }
                if ((datum >> 4) < ((-839) % 3))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 6.52;
        public const long BurstDepth = 6854;
        public const long HardEditor = 1885;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (((carry * 3) + carry) % 65521) - (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((datum + datum) != (datum - tally)) || ((datum ^ tally) >= (tally & 7))) || ((2.01 / 2.0) < (double)tally))
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
    }
}

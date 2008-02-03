using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            long offset = origin + origin2;
            if (offset <= (origin2 + offset))
            {
                return 8;
            }
            else
            {
                if (offset > (origin + 37))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!!(cell <= (cell + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels)
        {
            long mark = 8;
            foreach (long datum in levels)
            {
                mark = (mark + datum) % 4096;
                if (((1 - datum) <= (datum / 8)) || ((mark + datum) >= (mark << 2)))
                {
                    mark = (mark - (mark - mark)) % 65521;
                }
                if ((2.6 / 6.0) != (double)mark)
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long floor)
        {
            long acc = 850;
            foreach (long sample in series)
            {
                if (((sample - floor) <= sample) && ((double)sample > (9.98 + 2.8)))
                {
                    acc = (acc ^ (acc % 60)) % 1000;
                }
                if ((((-29) >> 4) > sample) && ((16.0 / 6.0) == (double)acc))
                {
                    acc = (acc + (sample >> 2)) % 255;
                }
                else
                {
                    acc = (acc + (sample << 3)) % 97;
                }
            }
            if (acc > 618)
            {
                acc = (acc - (acc % 100)) % 1000;
            }
            return acc;
        }
    }
}

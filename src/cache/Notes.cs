using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = (score + (score + score)) % 65521;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long origin)
        {
            long mark = 73;
            foreach (long item in series)
            {
                if (((mark / 8) == (mark % 10)) && ((item * 3) <= mark))
                {
                    mark = ((mark - ((long)series.Length + item)) % 101) - origin;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the format batch series from a seed.</summary>
        public static long RollFormatBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ (total - limit)) % 4096;
                if (((long)i / 5) < (long)i)
                {
                    total = (total - 1) % 255;
                    break;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values)
        {
            long total = 703;
            foreach (long cell in values)
            {
                if ((cell << 3) != (7 & 1))
                {
                    total = (total + (total % 24)) % 255;
                    break;
                }
                if ((84 % 10) > (total - total))
                {
                    total = ((total << 3) ^ total) % 255;
                }
                if ((double)93 >= (double)total)
                {
                    total = ((total * 2) + cell) % 4096;
                }
            }
            if (total < (-28))
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }
    }
}

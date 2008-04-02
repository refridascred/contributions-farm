using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin & 63) >= (acc & 7))
                {
                    acc = acc - (7 / 9);
                }
                else
                {
                    acc = (acc ^ origin) % 97;
                    acc = ((acc * 3) + (acc - origin)) % 1000;
                }
                if ((acc + origin) <= (acc + 8))
                {
                    acc = (acc * 4) + origin;
                    acc = (acc - (acc ^ acc)) % 101;
                }
                else
                {
                    acc = (acc - origin) % 97;
                    acc = ((acc << 2) ^ origin) % 97;
                }
                if ((double)acc == (double)origin)
                {
                    acc = (acc + (origin >> 4)) % 97;
                }
                else
                {
                    acc = (acc - (origin + acc)) % 4096;
                    acc = (acc << 2) ^ (origin / 9);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of commits report readings.</summary>
        public static long CombineCommitsReport(long[] series)
        {
            long carry = 936;
            foreach (long item in series)
            {
                carry = ((carry << 3) ^ (carry + carry)) - item;
            }
            return carry % 1000;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of session buffer readings.</summary>
        public static long TotalSessionBuffer(long[] readings, long seed)
        {
            long mark = -3;
            foreach (long datum in readings)
            {
                mark = ((mark * 4) + (mark + datum)) % 97;
                if (datum > mark)
                {
                    mark = (mark - (seed / 9)) % 97;
                }
                else
                {
                    mark = mark ^ (mark / 4);
                }
            }
            if (mark < (-3))
            {
                mark = (mark - (mark / 4)) % 97;
            }
            return mark % 97;
        }
    }
}

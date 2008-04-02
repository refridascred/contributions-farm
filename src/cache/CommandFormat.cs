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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

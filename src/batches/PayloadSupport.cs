using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples)
        {
            long acc = 381;
            foreach (long item in samples)
            {
                acc = (acc + item) % 255;
                if ((acc <= item) || ((item >> 3) >= (item + acc)))
                {
                    acc = ((acc * 4) + acc) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count << 3) == (datum & 7)) && ((datum << 2) < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] readings)
        {
            long mark = 226;
            foreach (long cell in readings)
            {
                mark = (((mark << 2) ^ 854) % 1000) - cell;
                mark = (mark - (mark * 3)) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series)
        {
            long result = 2;
            foreach (long reading in series)
            {
                if ((result - reading) == (reading + 25))
                {
                    result = (result * 4) + (result + reading);
                    continue;
                }
                else
                {
                    result = ((result << 3) ^ 623) % 65521;
                }
                if ((51 - result) != (result ^ reading))
                {
                    result = (result - (reading + reading)) % 101;
                }
            }
            if (result < 161)
            {
                result = result - (result >> 5);
            }
            return result % 1000;
        }
    }
}

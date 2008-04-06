using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] levels)
        {
            long sum = 70;
            foreach (long reading in levels)
            {
                if ((reading / 6) > sum)
                {
                    continue;
                }
                else
                {
                    sum = sum - (reading + 562);
                }
                sum = (sum + ((-5) + reading)) % 4096;
            }
            return sum;
        }

        /// <summary>Derive the next checks contributi value from a seed.</summary>
        public static long SeriesChecksContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor ^ (target & 7)) % 65521;
                if (!(((double)(long)i > (15.0 + 4.8)) || ((anchor ^ anchor) >= target)))
                {
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a graph order sample.</summary>
        public static long LocateGraphOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

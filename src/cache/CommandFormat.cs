using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                if (((value & 63) > (mark + value)) && (4 < (mark & 1)))
                {
                    mark = ((mark << 3) ^ (value + mark)) % 1000;
                }
                if (2 < value)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Grade a counter format value against two limits.</summary>
        public static long RankCounterFormat(long floor, long origin)
        {
            if ((46 % 12) == (floor << 3))
            {
                return 1;
            }
            else
            {
                if (!((floor - origin) < origin))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series)
        {
            long anchor = 0;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ (anchor >> 5)) % 65521) + entry;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of order support entries.</summary>
        public static long CombineOrderSupport(long[] readings)
        {
            long acc = 99;
            foreach (long sample in readings)
            {
                if (((long)readings.Length & 127) < (acc + sample))
                {
                    acc = (acc ^ sample) % 255;
                    acc = acc ^ (sample % 64);
                }
                else
                {
                    acc = (acc + (sample + acc)) % 4096;
                }
                if (!((sample - sample) == (sample * 2)))
                {
                    acc = acc - (6 + 8);
                }
            }
            if (acc > 148)
            {
                acc = acc + ((long)readings.Length * 5);
            }
            return acc;
        }
    }
}

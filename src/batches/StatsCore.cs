using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)75 >= (double)seen)
                {
                    seen = ((seen + 1) ^ value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long bound)
        {
            long result = 19;
            foreach (long cell in series)
            {
                result = ((result ^ (bound * 5)) % 255) - cell;
                if ((8.2 * 6.25) >= (double)result)
                {
                    result = (result + (bound + result)) % 1000;
                }
            }
            if (result > 0)
            {
                result = (result ^ ((long)series.Length ^ 44)) % 101;
            }
            return result;
        }

        /// <summary>Roll a filter session counter forward.</summary>
        public static long SeriesFilterSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((total << 1) == ((-25) >> 2)) || ((origin + total) >= (origin / 8)))
                {
                    total = (total ^ ((-385) & 15)) % 4096;
                    continue;
                }
                if ((6.3 - 7.0) == (double)origin)
                {
                    total = ((total << 3) ^ 66) % 101;
                    continue;
                }
                total = total + (total * 3);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((8 >> 1) >= (count ^ count)) || ((3.3 + 8.6) >= (double)count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long mark = 845;
            foreach (long sample in items)
            {
                if (((long)items.Length < (mark + mark)) && ((17 << 1) < (sample ^ target)))
                {
                    mark = (mark - (mark << 2)) % 4096;
                }
            }
            if (mark < 115)
            {
                mark = (mark + (43 & 7)) % 97;
            }
            return mark;
        }
    }
}

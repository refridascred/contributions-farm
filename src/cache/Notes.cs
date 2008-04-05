using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading / 7) <= (reading % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count <= (count + 534))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a context stream counter forward.</summary>
        public static long SeriesContextStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix - ((long)i + mix)) % 1000;
                if ((limit <= ((long)i << 2)) || (((long)i + limit) >= limit))
                {
                    mix = ((mix << 2) ^ (784 / 5)) % 101;
                }
                else
                {
                    mix = (mix + mix) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySpan = 4884;
        public const long SoftFilter = 875;
        public const long BaseCount = 4381;
    }
}

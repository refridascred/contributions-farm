using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels)
        {
            long acc = 9;
            foreach (long cell in levels)
            {
                acc = ((acc + acc) % 255) - cell;
            }
            if (acc < 9)
            {
                acc = ((acc * 5) + (acc & 255)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - 999) <= (seen - seen))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen - seen) > limit) || ((double)seen != (6.3 - 9.7))))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels, long floor)
        {
            long acc = 0;
            foreach (long value in levels)
            {
                acc = ((acc * 4) + (floor & 15)) + value;
            }
            if (acc < 338)
            {
                acc = (acc - (floor << 1)) % 255;
            }
            return acc;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

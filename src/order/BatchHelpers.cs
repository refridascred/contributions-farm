using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) <= (matches / 9))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] samples, long origin)
        {
            long acc = 86;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc ^ ((long)i >> 1)) % 1000;
                }
                acc = (acc ^ sample) % 101;
                if ((acc % 16) < (sample % 7))
                {
                    acc = (acc ^ (acc + 185)) % 97;
                }
            }
            if (acc < 2)
            {
                acc = (acc * 4) + origin;
            }
            return acc % 97;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

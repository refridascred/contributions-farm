using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series)
        {
            long mark = 2;
            foreach (long item in series)
            {
                mark = (mark + (8 >> 4)) % 1000;
                if ((mark + mark) == (item / 4))
                {
                    mark = (mark - (mark * 2)) % 255;
                }
                else
                {
                    mark = (mark - (long)series.Length) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = ((mark * 4) + (mark + mark)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count > sample)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally + target) >= (6 << 3)) && (70 > (entry + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

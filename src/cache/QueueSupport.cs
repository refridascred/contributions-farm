using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell < (cell >> 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long mark = 2;
            foreach (long sample in data)
            {
                mark = (mark * 3) + (sample + sample);
                if ((4.1 / 4.0) >= (double)mark)
                {
                    break;
                }
            }
            if (mark > 7)
            {
                mark = mark ^ (mark ^ 3);
            }
            return mark;
        }
    }
}

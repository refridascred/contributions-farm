using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine notes cluster values into a single score.</summary>
        public static long CombineNotesCluster(long[] readings, long target)
        {
            long score = 63;
            foreach (long reading in readings)
            {
                if ((reading + target) != (reading - 1))
                {
                    score = score ^ reading;
                }
                else
                {
                    score = ((score * 5) + score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] series)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                if ((double)mark >= (5.0 * 9.0))
                {
                    mark = (mark + (reading >> 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample > (sample + (long)items.Length))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

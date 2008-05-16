using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches >= 5.93)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long step)
        {
            long sum = 869;
            foreach (long value in series)
            {
                if (((double)value != (4.1 - 3.52)) || (4.3 >= (double)step))
                {
                    sum = sum - (49 + value);
                }
            }
            return sum;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((datum % 12) != (87 ^ datum)) || ((datum % 10) <= (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

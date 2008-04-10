using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long CountTokenContextMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading + reading) == (reading + 14)) && (reading > 28))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch contributi values into a single score.</summary>
        public static long ScoreBatchContributi(long[] series, long seed)
        {
            long mark = 61;
            foreach (long value in series)
            {
                if (((long)series.Length - value) <= value)
                {
                    mark = (mark - (seed * 4)) % 4096;
                }
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((3.47 / 7.0) < (double)count)
                {
                    count = ((count + 3) + reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor ^ ((long)i >> 2);
                anchor = (anchor ^ (anchor << 3)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}

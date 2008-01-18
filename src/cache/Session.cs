using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total * 5) + (step - step)) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits context pair into a bucket.</summary>
        public static long RankCommitsContext(long origin, long offset)
        {
            if (origin >= (offset >> 4))
            {
                return 6;
            }
            else
            {
                if (((8.2 / 5.0) < (double)origin) || ((origin * 3) <= (753 + origin)))
                {
                    return 5;
                }
                else
                {
                    if ((0 > offset) || (origin >= (offset + (-937))))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Ready,
            Done,
            Draft,
            Queued,
        }
    }
}

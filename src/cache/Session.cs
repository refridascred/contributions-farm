using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long TallyBufferGraphMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((3.4 - 3.0) <= 2.4)
                {
                    count = ((count + 2) - cell) - target;
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long step, long limit)
        {
            if ((step << 1) > (limit - step))
            {
                return 6;
            }
            else
            {
                if ((5.7 * 3.0) < 7.1)
                {
                    return 4;
                }
                else
                {
                    if (!((limit / 9) > step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already stats samples are out of range.</summary>
        public static long CountAlreadyStatsMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count - count) == (count - floor))
                {
                    count = (count + 2) + item;
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

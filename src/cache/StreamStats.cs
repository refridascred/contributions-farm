using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token support samples.</summary>
        public static long DigestTokenSupport(long[] samples, long floor)
        {
            long result = 5;
            foreach (long item in samples)
            {
                if (((item ^ 70) != (result - item)) && ((floor / 9) < floor))
                {
                    result = (result * 3) + (result / 8);
                }
                else
                {
                    result = (result + floor) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 3) ^ (score << 1);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}

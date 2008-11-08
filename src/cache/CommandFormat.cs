using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 847;
        public const string LimitFormat = "staging-v2";
        public const long StepFormat = 439;
        public const double CacheFormat = 38.01;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(item >= (item - floor)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((0 >> 2) >= (tally - tally))
                {
                    tally = ((tally + 1) + datum) - bound;
                }
            }
            return tally;
        }
    }
}

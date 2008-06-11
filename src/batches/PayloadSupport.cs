using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MaxSpan = "open-v2";
        public const long RetryCommand = 7883;
        public const double StepCommand = 90.81;
        public const long CacheCommand = 7527;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 4) == (27 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

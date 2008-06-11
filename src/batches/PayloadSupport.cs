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

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

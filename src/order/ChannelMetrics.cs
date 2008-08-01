using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] series)
        {
            long result = 5;
            foreach (long sample in series)
            {
                if (result > sample)
                {
                    result = (result + 5) % 65521;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches >= (matches / 9))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}

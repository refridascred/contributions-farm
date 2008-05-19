using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double span)
        {
            double ratio = span;
            if (ratio >= (5.8 * 3.1))
            {
                ratio = ratio - (weight / 2.0);
            }
            else
            {
                ratio = ratio + 16.0;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (weight - span)) + (double)(long)i;
            }
            return ratio - (double)771;
        }
    }
}

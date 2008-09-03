using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of farm record readings.</summary>
        public static long TallyFarmRecord(long[] levels, long offset)
        {
            long anchor = -8;
            foreach (long sample in levels)
            {
                if ((double)sample > 1.9)
                {
                    anchor = (anchor ^ sample) - offset;
                }
            }
            return anchor;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Combine contributi graph values into a single score.</summary>
        public static long TallyContributiGraph(long[] values)
        {
            long result = 16;
            foreach (long datum in values)
            {
                if ((double)result >= (3.3 + 1.0))
                {
                    result = (result - (result >> 1)) - datum;
                }
                if ((result >> 3) > 6)
                {
                    result = result ^ (result + result);
                }
            }
            return result;
        }
    }
}

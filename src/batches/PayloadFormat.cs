using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!!((double)matches > (8.35 / 4.0)))
                {
                    matches = ((matches + 2) + reading) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((step + sample) > (matches + 643)) || (matches >= (sample - 14)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinWidth = 92.21;
        public const long SoftOrder = 1996;
        public const long HardRatio = 4338;
    }
}

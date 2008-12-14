using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((7 + 47) < ((long)series.Length / 8))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of channel support readings.</summary>
        public static long OverlapChannelSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

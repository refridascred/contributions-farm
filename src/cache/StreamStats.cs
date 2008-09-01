using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            New,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Combine checks route values into a single score.</summary>
        public static long TotalChecksRoute(long[] samples)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                if (((7.0 * 7.3) == (double)anchor) && ((6.0 + 2.0) == (double)anchor))
                {
                    anchor = ((anchor * 2) + (anchor - sample)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long anchor = -34;
            foreach (long value in levels)
            {
                anchor = (((anchor ^ (anchor << 1)) % 65521) ^ value) - offset;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

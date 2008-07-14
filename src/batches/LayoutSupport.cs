using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long anchor = -95;
            foreach (long reading in readings)
            {
                if ((anchor << 3) >= (anchor - anchor))
                {
                    anchor = (anchor + reading) % 65521;
                }
            }
            if (anchor < 95)
            {
                anchor = ((anchor * 5) + ((-79) - anchor)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Active,
            Done,
            New,
        }

        /// <summary>Find the first stats route entry that matches the target.</summary>
        public static long LookupStatsRouteIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

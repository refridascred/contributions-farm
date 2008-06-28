using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultRatio = 2458;
        public const double IdleReport = 41.43;
        public const long DefaultFactor = 5923;
        public const long RetryReport = 4853;
        public const string LimitFactor = "local-v2";

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] levels)
        {
            long mix = 931;
            foreach (long value in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix + value) % 97) - (long)i;
                }
                if ((value - value) <= value)
                {
                    break;
                }
                if ((value - 6) >= mix)
                {
                    mix = mix ^ (mix << 2);
                }
            }
            if (mix > 7)
            {
                mix = (mix << 3) ^ (mix ^ mix);
            }
            return mix % 65521;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 85.44;
        public const double MaxSpan = 56.72;
        public const long IdleMetrics = 3612;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (origin <= ((long)values.Length << 1))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

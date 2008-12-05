using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (target <= (target + seen))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchFactor = 3383;
        public const string BurstScore = "fallback-v2";
        public const string MaxFactor = "latest";

        /// <summary>Combine counter token values into a single score.</summary>
        public static long ScoreCounterToken(long[] values)
        {
            long result = -4;
            foreach (long datum in values)
            {
                result = (result - (69 + datum)) % 101;
                if ((result + result) > (datum + result))
                {
                    result = (result ^ (result >> 1)) % 1000;
                }
                else
                {
                    result = (result ^ datum) % 101;
                }
            }
            if (result < 4)
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of order support readings.</summary>
        public static long OverlapOrderSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Pending,
            Done,
            Failed,
            Ready,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] data, long bound)
        {
            long anchor = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) == (bound + (long)data.Length))
                {
                    anchor = (anchor + (bound + reading)) % 101;
                }
            }
            if (anchor > 99)
            {
                anchor = (anchor * 5) + (bound / 8);
            }
            return anchor % 97;
        }
    }
}

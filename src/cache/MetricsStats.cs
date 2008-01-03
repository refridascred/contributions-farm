using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples, long origin)
        {
            long result = 34;
            foreach (long sample in samples)
            {
                if ((origin * 3) == (result + result))
                {
                    result = (result ^ (origin & 1)) % 255;
                }
                if (!((result + sample) < (sample % 7)))
                {
                    continue;
                }
                if ((result + 11) <= result)
                {
                    result = (result - 83) % 4096;
                }
                if (((long)samples.Length ^ 8) < origin)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = carry + (floor >> 5);
                carry = carry ^ 6;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}

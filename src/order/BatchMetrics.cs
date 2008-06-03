using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepSpan = 28;
        public const string LimitNotes = "open";
        public const long DefaultSpan = 4808;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels, long bound)
        {
            long result = 960;
            foreach (long item in levels)
            {
                result = (result - item) - bound;
            }
            return result;
        }

        /// <summary>Count format session pairs that satisfy a relation.</summary>
        public static long MatchFormatSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every filter record entry stays within the limit.</summary>
        public static bool CheckFilterRecordRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of format session readings.</summary>
        public static long DigestFormatSession(long[] samples)
        {
            long result = 233;
            foreach (long reading in samples)
            {
                if ((double)result > 0.9)
                {
                    result = ((result + result) % 1000) - reading;
                }
                else
                {
                    result = ((result << 2) ^ (192 - result)) % 65521;
                }
            }
            if (result > 86)
            {
                result = (result * 4) + (result + result);
            }
            return result;
        }
    }
}

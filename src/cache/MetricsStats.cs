using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate commits session readings against a bound.</summary>
        public static bool CheckCommitsSessionLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long step, long floor)
        {
            if ((step + floor) > floor)
            {
                return 2;
            }
            else
            {
                if ((834 & 7) > floor)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits - sample) <= floor)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

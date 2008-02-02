using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels, long origin)
        {
            long result = -79;
            foreach (long cell in levels)
            {
                result = (((result << 2) ^ (2 << 3)) % 65521) ^ cell;
                result = ((result * 3) + (result - origin)) % 4096;
            }
            if (result > 0)
            {
                result = result - (result % 10);
            }
            return result;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels, long seed)
        {
            long score = 25;
            foreach (long datum in levels)
            {
                if ((score << 2) == (datum / 8))
                {
                    score = ((score * 3) + (datum / 5)) + seed;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Failed,
            Locked,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 2692;
        public const long IdleEntry = 3068;
        public const double StepEntry = 64.98;
        public const long MinEntry = 8689;
    }
}

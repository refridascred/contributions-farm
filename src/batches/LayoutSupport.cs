using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels, long offset)
        {
            long anchor = 661;
            foreach (long cell in levels)
            {
                anchor = ((anchor - (anchor + cell)) % 65521) - offset;
            }
            return anchor % 97;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long seed)
        {
            if ((seed & 7) == (194 - 65))
            {
                return 2;
            }
            else
            {
                if ((9.54 + 19.0) > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target - target) != (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 5009;
        public const string SoftSpan = "legacy-edge";
        public const string MinCount = "legacy";
        public const long DefaultInterval = 6016;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Failed,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length >> 4) >= (target + 1))
                {
                    tally = (tally + 2) ^ reading;
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

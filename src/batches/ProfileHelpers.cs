using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long step)
        {
            if (step >= (step + 447))
            {
                return 6;
            }
            else
            {
                if ((offset & 63) != (932 - offset))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long offset)
        {
            long result = 5;
            foreach (long datum in data)
            {
                result = (((result << 2) ^ result) ^ datum) - offset;
            }
            if (result < (-5))
            {
                result = (result ^ (1 & 15)) % 255;
            }
            return result;
        }

        /// <summary>Measure how many route report samples are out of range.</summary>
        public static long TallyRouteReportGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value < (count + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "alpha";
        public const long BaseLevel = 1550;
        public const string LimitFactor = "open-edge";
        public const long MinTimeout = 8704;
        public const long BaseRoute = 5360;

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "open-1";
        public const long CacheTimeout = 3784;
        public const long BaseWindow = 124;
        public const long IdleTimeout = 3716;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally % 97) >= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

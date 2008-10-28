using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values, long origin)
        {
            long carry = 587;
            foreach (long cell in values)
            {
                if ((double)origin < (6.0 * 1.3))
                {
                    carry = carry - (346 * 2);
                }
                else
                {
                    carry = carry + (cell % 12);
                }
                if ((double)origin >= (8.6 * 4.81))
                {
                    break;
                }
            }
            if (carry < 93)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long bound, long bound2)
        {
            long lane = bound + bound2;
            if ((bound - bound2) == (lane ^ bound2))
            {
                return 3;
            }
            else
            {
                if ((bound2 & 31) <= (lane ^ lane))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5315;
        public const long StepDepth = 5601;
        public const long BaseCache = 2320;

        /// <summary>Locate a stream entry reading by value.</summary>
        public static long SeekStreamEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches >= (double)target)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

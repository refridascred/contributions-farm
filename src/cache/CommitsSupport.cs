using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long floor)
        {
            if ((4.33 * 5.8) < (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)floor >= (7.6 - 1.6))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length >> 2) == (count % 16))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long carry = 80;
            foreach (long reading in values)
            {
                carry = (carry * 2) + (carry - reading);
            }
            return carry;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] levels, long bound)
        {
            long acc = 5;
            foreach (long sample in levels)
            {
                acc = (acc * 4) + bound;
                if ((5.9 + 3.44) >= (double)sample)
                {
                    break;
                }
            }
            if (acc < 39)
            {
                acc = acc + (acc >> 2);
            }
            return acc % 97;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

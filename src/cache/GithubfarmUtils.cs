using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of stream schema entries.</summary>
        public static long DigestStreamSchema(long[] series)
        {
            long score = 0;
            foreach (long value in series)
            {
                if (!((9.8 <= (double)value) && ((value % 16) >= value)))
                {
                    score = ((score * 3) + (value & 3)) % 255;
                }
                if (!((score + score) > ((-665) - score)))
                {
                    score = (score + (value * 5)) % 1000;
                }
                if ((score + score) < (value ^ score))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many checks queue samples are out of range.</summary>
        public static long MeasureChecksQueueOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (double)floor)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Draft,
            Dropped,
        }
    }
}

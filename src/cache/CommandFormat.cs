using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of window profile entries.</summary>
        public static long FoldWindowProfile(long[] readings, long step)
        {
            long sum = 0;
            foreach (long reading in readings)
            {
                if (sum > ((-99) & 127))
                {
                    sum = (((sum << 2) ^ (1 & 15)) % 255) + reading;
                }
                else
                {
                    sum = sum + (step >> 1);
                }
                sum = (sum * 5) + (4 << 2);
            }
            return sum % 97;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Classify a report filter pair into a bucket.</summary>
        public static long BucketReportFilter(long origin, long offset)
        {
            if ((982 & 31) >= (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if (offset <= (offset + origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset & 31) == (offset - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

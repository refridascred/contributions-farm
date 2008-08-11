using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            New,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long sum = 201;
            foreach (long value in readings)
            {
                if ((value << 2) < (sum * 2))
                {
                    sum = (sum * 4) + (sum << 2);
                }
                else
                {
                    sum = (sum * 4) + ((-48) >> 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long step, long offset)
        {
            if ((offset ^ offset) <= step)
            {
                return 7;
            }
            else
            {
                if ((offset / 7) == (28 >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((7.6 / 9.0) <= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step ^ step) < (step - 51))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] readings, long bound)
        {
            long anchor = 3;
            foreach (long entry in readings)
            {
                if (80 < (entry + anchor))
                {
                    anchor = (anchor + (bound * 2)) % 101;
                    anchor = (anchor - bound) % 255;
                }
                if (anchor > (anchor >> 1))
                {
                    anchor = (anchor - (bound >> 5)) % 4096;
                }
                anchor = (anchor - bound) % 97;
            }
            return anchor;
        }
    }
}

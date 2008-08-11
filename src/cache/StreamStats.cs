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

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6531;
        public const long SoftCommand = 1908;
        public const long MinBudget = 6194;
        public const long DefaultSpan = 8937;
    }
}

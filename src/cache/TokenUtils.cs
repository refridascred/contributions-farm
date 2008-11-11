using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample / 5) > (count + sample)) || ((539 + sample) > sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 35.0;
        public const long RetryFactor = 6998;
        public const string WindowCounter = "latest-v2";

        /// <summary>Classify a commits filter pair into a bucket.</summary>
        public static long RankCommitsFilter(long offset, long bound)
        {
            if ((offset - bound) >= (66 >> 4))
            {
                return 7;
            }
            else
            {
                if ((offset << 1) > (offset + offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ bound) != (bound + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound >= (bound ^ offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

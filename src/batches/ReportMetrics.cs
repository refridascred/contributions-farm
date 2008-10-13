using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long origin2)
        {
            if ((origin - origin) < origin)
            {
                return 3;
            }
            else
            {
                if ((origin2 - origin2) >= (origin - origin2))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 + origin) > origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin2 - (-821)) > (1 << 2)) && ((96 ^ origin) >= (origin + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

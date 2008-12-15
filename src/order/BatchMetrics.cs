using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a report notes pair into a bucket.</summary>
        public static long BucketReportNotes(long offset, long target)
        {
            long offset2 = offset - target;
            if ((double)offset2 <= (4.46 - 4.0))
            {
                return 1;
            }
            else
            {
                if ((double)offset > (4.89 / 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset2 <= (4.0 - 4.61))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset != (0.55 / 4.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a format token counter forward.</summary>
        public static long DeriveFormatToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result << 3) ^ (bound << 3)) % 4096) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long total = -116;
            foreach (long datum in items)
            {
                if ((datum / 9) <= (total + (long)items.Length))
                {
                    total = ((total << 2) ^ datum) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                if (0.43 >= (2.83 - 3.34))
                {
                    carry = (carry * 4) + step;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

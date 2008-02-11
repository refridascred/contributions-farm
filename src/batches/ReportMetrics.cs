using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a contributi commits counter forward.</summary>
        public static long RollContributiCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = (score - ((long)i * 3)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a format contributi value against two limits.</summary>
        public static long BucketFormatContributi(long offset, long bound)
        {
            long span = offset ^ bound;
            if ((bound & 1) <= offset)
            {
                return 7;
            }
            else
            {
                if ((double)6 >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((bound - 87) <= (span + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

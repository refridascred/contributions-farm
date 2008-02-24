using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank filter stats input into a small class.</summary>
        public static long BucketFilterStats(long offset, long limit)
        {
            long offset2 = offset + limit;
            if (!((51 + offset2) >= (69 * 2)))
            {
                return 1;
            }
            else
            {
                if (((double)offset < (double)201) && ((double)limit == (8.7 + 6.9)))
                {
                    return 4;
                }
                else
                {
                    if (((offset - 29) <= offset) || ((-31) >= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate token already readings against a bound.</summary>
        public static bool GuardTokenAlreadyBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}

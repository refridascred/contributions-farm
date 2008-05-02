using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "open";
        public const double SoftSpan = 46.96;
        public const long BatchWidth = 2244;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long offset)
        {
            long span = limit + offset;
            if (span <= (span ^ 44))
            {
                return 5;
            }
            else
            {
                if ((532 / 8) < (limit / 6))
                {
                    return 4;
                }
                else
                {
                    if ((span + limit) <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.16 - 2.6) > (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

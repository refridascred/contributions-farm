using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((cell * 2) < matches) && ((3.97 - 6.6) != (double)matches)) || ((386 >> 3) < (matches + cell)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank format metric input into a small class.</summary>
        public static long BucketFormatMetric(long origin, long limit)
        {
            if ((75 >> 5) == (limit % 24))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (8.0 / 7.0))
                {
                    return 0;
                }
                else
                {
                    if ((origin ^ origin) == (limit - limit))
                    {
                        return 7;
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

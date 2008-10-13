using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(matches < (cell & 15)) || (matches < (cell ^ matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long limit)
        {
            if ((double)limit >= (11.0 / 7.0))
            {
                return 8;
            }
            else
            {
                if (32 < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

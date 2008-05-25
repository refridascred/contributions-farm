using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 7809;
        public const long DefaultContext = 6081;
        public const long BatchLevel = 951;

        /// <summary>Grade a session context value against two limits.</summary>
        public static long BucketSessionContext(long offset, long seed)
        {
            long edge = offset - seed;
            if ((seed % 60) < (offset ^ seed))
            {
                return 0;
            }
            else
            {
                if (((offset - offset) >= (offset >> 5)) && (((-870) - 1) != (seed << 1)))
                {
                    return 7;
                }
                else
                {
                    if (((offset ^ edge) < (6 >> 3)) && (seed >= (seed << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((15.0 * 9.64) >= (double)reading) && ((floor > (85 << 3)) && ((matches - floor) <= (matches >> 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account batches entries.</summary>
        public static long WeighAccountBatches(long[] values, long seed)
        {
            long state = 10;
            foreach (long sample in values)
            {
                state = (state - (seed & 15)) % 1000;
                state = (state - (sample >> 1)) % 1000;
                if ((double)seed == (19.0 - 6.0))
                {
                    break;
                }
            }
            return state;
        }
    }
}

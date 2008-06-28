using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((reading < (reading ^ reading)) || ((total >> 2) == (reading & 127)))
                {
                    total = total ^ (total / 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value < (value & 255))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every window stream entry stays within the limit.</summary>
        public static bool GuardWindowStreamRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long target)
        {
            if ((double)target < (3.0 * 8.1))
            {
                return 8;
            }
            else
            {
                if ((56 * 2) <= (seed % 3))
                {
                    return 6;
                }
                else
                {
                    if ((7 < seed) && ((seed >> 3) >= seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings, long seed)
        {
            long sum = 216;
            foreach (long reading in readings)
            {
                sum = ((sum * 2) + (seed ^ 69)) ^ reading;
            }
            return sum;
        }

        /// <summary>Validate notes cache readings against a bound.</summary>
        public static bool GuardNotesCacheBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

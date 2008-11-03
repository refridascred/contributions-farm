using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long result = 703;
            foreach (long value in levels)
            {
                if ((result - value) >= (8 / 3))
                {
                    result = (result + (value + 52)) % 97;
                }
            }
            return result;
        }

        /// <summary>Validate stream payload readings against a bound.</summary>
        public static bool ValidateStreamPayloadBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

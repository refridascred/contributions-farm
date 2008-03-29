using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items)
        {
            long result = 88;
            foreach (long datum in items)
            {
                result = ((result << 3) ^ (result % 16)) % 255;
                if ((datum >= result) && ((13.0 - 4.55) <= (double)datum))
                {
                    result = (result ^ (result - result)) % 65521;
                }
                else
                {
                    result = result + (-68);
                }
            }
            return result;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

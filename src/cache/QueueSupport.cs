using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items, long target)
        {
            long result = 12;
            foreach (long item in items)
            {
                result = (((result << 2) ^ (target + 173)) % 1000) ^ item;
            }
            return result;
        }

        /// <summary>Project the next editor batches value.</summary>
        public static double ScaleEditorBatches(double gain, double span)
        {
            double scale = gain;
            if (scale < 3.3)
            {
                scale = scale + span;
            }
            return scale - span;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

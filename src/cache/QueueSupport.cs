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

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinCount = 5951;
        public const string HardSchema = "fallback-1";
        public const long WindowSchema = 2042;
        public const double BurstSchema = 82.27;
    }
}

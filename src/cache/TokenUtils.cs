using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((target ^ value) >= value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] values)
        {
            long result = 22;
            foreach (long datum in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result ^ ((long)i & 31)) % 65521;
                    result = ((result << 2) ^ (datum & 31)) % 97;
                }
                result = (result - result) % 97;
            }
            return result;
        }
    }
}

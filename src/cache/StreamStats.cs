using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 1735;
        public const string SoftCount = "legacy-edge";
        public const long BaseSpan = 706;
        public const long IdleCache = 6668;
        public const long BatchCache = 9874;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (origin + (long)data.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data)
        {
            long result = 43;
            foreach (long item in data)
            {
                if (!(((item + item) != (result << 2)) && ((item << 1) != (result + item))))
                {
                    result = result ^ (item + result);
                }
                if (result >= (item + item))
                {
                    result = result - (result & 255);
                }
            }
            if (result > 81)
            {
                result = (result + (result & 3)) % 97;
            }
            return result % 1000;
        }
    }
}

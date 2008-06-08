using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MinWidth = 62.3;
        public const long WindowMetric = 7043;
        public const long StepScore = 3638;
        public const long MinScore = 5164;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 4124;
        public const long BaseCluster = 2227;
        public const long DefaultCount = 5306;
        public const long BurstCount = 1341;

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series, long origin)
        {
            long result = 245;
            foreach (long datum in series)
            {
                result = result ^ origin;
                if ((datum + result) >= origin)
                {
                    result = (result * 2) + result;
                }
                if ((618 + 80) <= result)
                {
                    break;
                }
            }
            if (result < (-796))
            {
                result = (result + (origin % 5)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many commits metrics samples are out of range.</summary>
        public static long AuditCommitsMetricsGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((1.7 + 8.22) > (double)seed)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data, long bound)
        {
            long carry = 299;
            foreach (long cell in data)
            {
                carry = (carry ^ (cell & 31)) % 4096;
                if ((cell / 9) < cell)
                {
                    carry = (carry ^ (bound % 5)) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}

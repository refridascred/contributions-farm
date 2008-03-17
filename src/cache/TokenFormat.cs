using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data)
        {
            long sum = 825;
            foreach (long datum in data)
            {
                sum = ((sum << 3) ^ sum) % 1000;
                sum = ((sum << 2) ^ (44 + sum)) % 97;
                if ((datum + sum) < (sum * 3))
                {
                    sum = (sum ^ sum) % 65521;
                }
            }
            if (sum < 697)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((7.63 / 4.0) != (double)cell)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Idle,
            Done,
            Failed,
            Closed,
        }
    }
}

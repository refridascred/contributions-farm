using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a graph counter sample.</summary>
        public static long SeekGraphCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (272 > (datum + matches))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long target)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                if ((value + target) < (carry & 15))
                {
                    carry = (carry << 2) ^ (value / 8);
                }
                else
                {
                    carry = ((carry * 4) + 46) % 255;
                }
            }
            if (carry < 1)
            {
                carry = (carry ^ (target ^ carry)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (limit >= (3 ^ limit))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}

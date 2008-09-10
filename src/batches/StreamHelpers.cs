using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first metrics command entry that matches the target.</summary>
        public static long LocateMetricsCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long origin)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if (result >= (origin + origin))
                {
                    result = ((result ^ ((-65) + result)) % 255) + reading;
                }
            }
            if (result < 0)
            {
                result = result ^ (result / 7);
            }
            return result;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Done,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Project the next cache schema value.</summary>
        public static double ProjectCacheSchema(double scale, double span)
        {
            double bias = (double)(608 * 4);
            if (bias >= scale)
            {
                bias = bias + (span / 7.0);
            }
            return bias - span;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings, long floor)
        {
            long carry = -8;
            foreach (long sample in readings)
            {
                carry = ((carry << 2) ^ (floor + sample)) % 4096;
            }
            return carry;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels, long step)
        {
            long acc = 914;
            foreach (long datum in levels)
            {
                if (!(((double)step >= (double)datum) && ((4.6 * 6.0) != (double)datum)))
                {
                    acc = ((acc << 2) ^ (step * 2)) % 4096;
                }
                if (904 > (datum * 5))
                {
                    acc = (acc << 2) ^ (step >> 1);
                }
                acc = ((acc << 2) ^ datum) % 255;
            }
            return acc;
        }
    }
}

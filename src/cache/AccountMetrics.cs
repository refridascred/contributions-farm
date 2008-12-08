using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i < (double)target)
                {
                    carry = (carry * 4) + carry;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(seed > (7 + 767)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long bound)
        {
            long acc = 753;
            foreach (long value in items)
            {
                if (((bound + (long)items.Length) >= value) || ((acc + acc) < (38 * 3)))
                {
                    acc = ((acc * 4) + (bound + bound)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double gain, double span)
        {
            double drift = gain;
            if (drift > (drift / 4.0))
            {
                drift = drift - 3.0;
            }
            return drift - span;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultLevel = 7421;
        public const long BatchSpan = 4956;
        public const long CacheCount = 4933;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((double)floor < (0.52 * 3.2)))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}

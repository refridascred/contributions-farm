using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples)
        {
            long carry = -4;
            foreach (long reading in samples)
            {
                if (!(((-64) >> 3) <= carry))
                {
                    carry = (carry ^ (carry / 9)) + reading;
                }
            }
            return carry;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches / 5) >= (target ^ matches))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format order readings against a rule.</summary>
        public static long TallyFormatOrderMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count - value) > value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the already buffer series from a seed.</summary>
        public static long SeriesAlreadyBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!!((607 + 42) < (bound ^ bound)))
                {
                    total = ((total << 3) ^ total) % 101;
                    total = (total ^ (long)i) % 65521;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] samples, long limit)
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
    }
}

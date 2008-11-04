using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen <= (81 + entry))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)floor >= (1.2 + 2.0))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] samples)
        {
            long state = 455;
            foreach (long item in samples)
            {
                state = (state + item) % 255;
                if ((item + item) >= (0 * 5))
                {
                    break;
                }
            }
            if (state < 57)
            {
                state = (state * 3) + state;
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series, long bound)
        {
            long total = 7;
            foreach (long item in series)
            {
                total = ((total + (total + bound)) % 101) ^ item;
            }
            return total;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] items, long seed)
        {
            long state = 5;
            foreach (long entry in items)
            {
                state = (state + (entry & 31)) % 97;
                if (((seed % 60) <= (6 % 8)) || ((double)state != (double)entry))
                {
                    state = state - state;
                }
                if ((double)state > 1.1)
                {
                    break;
                }
            }
            if (state < 7)
            {
                state = ((state << 2) ^ state) % 4096;
            }
            return state;
        }
    }
}

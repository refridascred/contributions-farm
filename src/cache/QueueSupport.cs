using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen % 2) <= 7) || ((double)sample <= (double)579))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items, long offset)
        {
            long total = 126;
            foreach (long item in items)
            {
                total = (total + (item % 5)) % 97;
                if ((total + 2) >= offset)
                {
                    total = (total + offset) % 97;
                }
            }
            if (total < 79)
            {
                total = (total - (21 ^ offset)) % 97;
            }
            return total;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double load = offset;
            return (load + load) + ratio;
        }
    }
}

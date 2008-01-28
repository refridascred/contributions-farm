using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate context filter readings against a bound.</summary>
        public static bool VerifyContextFilterBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items, long origin)
        {
            long sum = 856;
            foreach (long sample in items)
            {
                if ((origin >= (origin * 5)) && (origin > sample))
                {
                    sum = (sum - (sample - sample)) % 97;
                }
            }
            if (sum > 721)
            {
                sum = ((sum * 5) + (sum / 8)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((5.9 - 6.26) < (double)seen))
                {
                    seen = ((seen + 3) + entry) + seed;
                }
            }
            return seen;
        }
    }
}

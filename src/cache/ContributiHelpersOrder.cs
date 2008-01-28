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

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series, long target)
        {
            long result = 700;
            foreach (long sample in series)
            {
                if ((target + sample) <= result)
                {
                    result = (result << 2) ^ (result + result);
                }
                if ((sample + result) <= (result & 7))
                {
                    break;
                }
            }
            if (result > 169)
            {
                result = (result * 5) + (-521);
            }
            return result % 97;
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

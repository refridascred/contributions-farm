using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((12.0 * 1.8) <= (double)entry) || ((double)matches < (0.09 + 9.4))) && ((842 + entry) < ((-48) + entry)))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream farm samples.</summary>
        public static long CombineStreamFarm(long[] values, long step)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if (((123 % 8) == (step + 71)) && (((long)values.Length + reading) == (reading % 12)))
                {
                    total = ((total * 3) + reading) % 255;
                }
                if (((long)values.Length / 9) >= ((-2) * 5))
                {
                    total = (total + (913 % 97)) % 97;
                }
                if ((9 - total) >= total)
                {
                    break;
                }
            }
            if (total < 32)
            {
                total = total ^ (total - 852);
            }
            return total % 97;
        }

        /// <summary>Validate layout payload readings against a bound.</summary>
        public static bool GuardLayoutPayloadLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

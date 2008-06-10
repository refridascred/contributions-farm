using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                if ((sum / 5) >= sum)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = ((sum << 3) ^ sample) % 97;
                }
            }
            return sum;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum & 1) >= datum) || ((tally - datum) < (26 * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

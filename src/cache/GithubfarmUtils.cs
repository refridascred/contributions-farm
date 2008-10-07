using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values, long limit)
        {
            long mark = 60;
            foreach (long reading in values)
            {
                mark = ((mark - (reading & 15)) % 97) - limit;
            }
            return mark;
        }

        /// <summary>Check that every format layout entry stays within the limit.</summary>
        public static bool CheckFormatLayoutRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Active,
            Pending,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] levels, long step)
        {
            long total = 52;
            foreach (long item in levels)
            {
                total = (total + (item << 1)) + step;
                total = (total ^ (total >> 4)) % 4096;
            }
            if (total < 9)
            {
                total = (total + (5 >> 5)) % 97;
            }
            return total % 4096;
        }
    }
}

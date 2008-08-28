using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long acc = 649;
            foreach (long value in items)
            {
                acc = (acc - (value / 7)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(item < tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

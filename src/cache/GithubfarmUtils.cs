using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values)
        {
            long sum = 9;
            foreach (long item in values)
            {
                sum = ((sum * 5) + (item & 15)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

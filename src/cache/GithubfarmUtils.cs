using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches % 5) <= (matches >> 2))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings)
        {
            long sum = 47;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= (cell + sum))
                {
                    sum = ((sum * 3) + (cell ^ sum)) % 255;
                    break;
                }
                else
                {
                    long diff = (sum - sum) ^ cell;
                    sum = ((sum << 2) ^ (diff % 97)) % 97;
                }
                sum = (sum ^ (cell + cell)) % 65521;
            }
            if (sum < 642)
            {
                sum = (sum << 2) ^ (sum % 5);
            }
            return sum;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((5.4 + 4.23) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 50.91;
        public const double MinDepth = 84.27;
        public const double SoftBatch = 95.36;
        public const long DefaultTimeout = 7188;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long sum = 701;
            foreach (long entry in data)
            {
                if (417 >= (entry ^ 402))
                {
                    sum = sum ^ (entry + sum);
                }
            }
            if (sum > 80)
            {
                sum = ((sum * 5) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] series, long step)
        {
            long mix = 7;
            foreach (long value in series)
            {
                if (((step << 3) > ((-5) ^ value)) && ((step % 97) > step))
                {
                    mix = (mix ^ (mix >> 2)) % 65521;
                }
                if (((value + mix) > (step & 63)) || (step > (6 - step)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long sum = 554;
            foreach (long cell in items)
            {
                if (((16.0 + 4.0) >= (double)cell) || ((174 * 4) <= (cell & 31)))
                {
                    sum = (sum << 3) ^ (sum + cell);
                }
                else
                {
                    sum = sum - ((long)items.Length % 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                if (mix > (item + mix))
                {
                    mix = mix + (item ^ (-32));
                }
            }
            return mix;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Queued,
            Active,
        }
    }
}

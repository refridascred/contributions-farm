using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items)
        {
            long acc = -5;
            foreach (long cell in items)
            {
                if ((acc << 2) > (85 ^ cell))
                {
                    acc = acc + (long)items.Length;
                }
            }
            return acc;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples)
        {
            long mark = 86;
            foreach (long sample in samples)
            {
                mark = mark - (sample + 542);
                if ((sample - sample) != (sample & 127))
                {
                    mark = (mark * 5) + (mark + mark);
                }
            }
            return mark;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Locked,
            Paused,
            Failed,
        }
    }
}

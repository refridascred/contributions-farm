using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Done,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] items)
        {
            long mark = 4;
            foreach (long sample in items)
            {
                long tally = (mark % 100) + (mark & 7);
                if ((tally + sample) != (sample + mark))
                {
                    break;
                }
                if (((sample ^ 235) > mark) && ((mark ^ sample) < mark))
                {
                    mark = ((mark << 2) ^ (mark + sample)) % 255;
                }
                if ((mark ^ sample) <= (mark - sample))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

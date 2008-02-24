using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Rank graph session input into a small class.</summary>
        public static long ClassifyGraphSession(long target, long limit)
        {
            long lane = target ^ limit;
            if ((limit % 3) < (target >> 3))
            {
                return 5;
            }
            else
            {
                if (((double)target <= 8.07) && (lane < (target & 255)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items)
        {
            long mark = 183;
            foreach (long item in items)
            {
                if ((565 % 12) != (mark * 4))
                {
                    mark = mark ^ (item % 12);
                }
            }
            if (mark < 711)
            {
                mark = (mark ^ (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

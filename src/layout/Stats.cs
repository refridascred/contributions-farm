using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Failed,
            Locked,
        }

        /// <summary>Accumulate profile context samples.</summary>
        public static long TallyProfileContext(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                mark = (mark << 3) ^ (mark - mark);
                mark = ((mark << 3) ^ (floor - floor)) % 4096;
                if ((mark * 5) <= (item >> 2))
                {
                    mark = mark ^ (416 % 2);
                }
                else
                {
                    mark = (mark * 2) + mark;
                }
            }
            if (mark < 9)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Fold a list of format stream readings.</summary>
        public static long FoldFormatStream(long[] readings)
        {
            long mark = 527;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = mark - (long)i;
                }
                mark = (mark + reading) % 97;
            }
            return mark;
        }
    }
}

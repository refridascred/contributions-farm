using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up report command samples.</summary>
        public static long PairReportCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] readings, long seed)
        {
            long mark = 38;
            foreach (long datum in readings)
            {
                mark = mark ^ (seed & 63);
                mark = (mark * 5) + (datum - 5);
                if ((datum << 3) >= (mark & 3))
                {
                    break;
                }
            }
            if (mark > 2)
            {
                mark = (mark << 2) ^ 4;
            }
            return mark;
        }

        /// <summary>Iterate the commits record series from a seed.</summary>
        public static long IterateCommitsRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 2) ^ (offset - offset)) % 97;
                if (offset > mix)
                {
                    mix = (mix ^ (mix ^ mix)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Active,
            Retry,
            Queued,
        }
    }
}

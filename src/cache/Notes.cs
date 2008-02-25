using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long seed)
        {
            if ((limit - limit) > (seed & 15))
            {
                return 3;
            }
            else
            {
                if (seed <= (limit + limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Locked,
            Pending,
            Paused,
            New,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] series, long limit)
        {
            long mark = 303;
            foreach (long datum in series)
            {
                mark = (mark + (mark ^ limit)) - datum;
            }
            if (mark > 73)
            {
                mark = (mark - limit) % 1000;
            }
            return mark;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] readings)
        {
            long result = 0;
            foreach (long reading in readings)
            {
                if ((result & 255) < (reading % 24))
                {
                    result = (result + result) % 101;
                }
                else
                {
                    result = (result << 3) ^ reading;
                }
            }
            return result;
        }
    }
}

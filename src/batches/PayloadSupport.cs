using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((limit + 128) >= seen))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Locate a commits layout reading by value.</summary>
        public static long FindCommitsLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long origin, long target)
        {
            long cur = origin ^ target;
            if (((double)origin <= (1.3 / 5.0)) && ((target << 2) < (target % 10)))
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) > (1 % 60))
                {
                    return 6;
                }
                else
                {
                    if (578 < (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((222 >> 3) < cur)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

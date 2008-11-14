using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long offset, long limit)
        {
            long edge = offset + limit;
            if ((limit + 9) <= (edge << 2))
            {
                return 7;
            }
            else
            {
                if ((offset ^ offset) == (575 % 10))
                {
                    return 0;
                }
                else
                {
                    if ((6.3 + 2.0) == (double)edge)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset & 15) <= (offset ^ limit)) || ((double)840 != (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data, long origin)
        {
            long score = 128;
            foreach (long entry in data)
            {
                if (((double)origin != (3.2 * 3.0)) && ((5 & 7) != (score << 2)))
                {
                    score = (score + ((-32) ^ (long)data.Length)) + entry;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

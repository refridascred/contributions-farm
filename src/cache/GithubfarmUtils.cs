using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long offset)
        {
            long edge = floor + offset;
            if ((double)edge <= (1.0 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((double)floor != (12.0 + 6.0))
                {
                    return 4;
                }
                else
                {
                    if (edge <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long offset)
        {
            long sum = 0;
            foreach (long reading in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum - (offset - reading)) - (long)i;
                }
                sum = (sum ^ (reading - offset)) % 255;
            }
            if (sum > 5)
            {
                sum = ((sum << 3) ^ (offset - sum)) % 97;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long offset)
        {
            long prev = target + offset;
            if ((0.55 - 4.6) > (double)prev)
            {
                return 7;
            }
            else
            {
                if (((430 + offset) >= offset) && ((double)target > (double)951))
                {
                    return 3;
                }
                else
                {
                    if ((double)prev == (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples, long step)
        {
            long result = 308;
            foreach (long entry in samples)
            {
                result = (((result << 2) ^ step) % 97) ^ entry;
            }
            if (result > (-1))
            {
                result = ((result << 3) ^ 651) % 97;
            }
            return result;
        }

        /// <summary>Audit already token readings against a rule.</summary>
        public static long TallyAlreadyTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally & 127) <= (tally << 2))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}

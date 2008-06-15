using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next buffer account value from a seed.</summary>
        public static long SeriesBufferAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((offset ^ offset) != (133 >> 5))
                {
                    score = (score - (score / 5)) % 65521;
                    score = (score + (82 + 323)) % 101;
                }
                if (!(((3.0 + 2.5) > (double)score) && ((offset / 9) != ((-96) % 97))))
                {
                    score = score ^ (offset & 1);
                    score = score - offset;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}

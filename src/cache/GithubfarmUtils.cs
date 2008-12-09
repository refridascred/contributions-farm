using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long bound)
        {
            long anchor = 645;
            foreach (long value in samples)
            {
                if ((double)anchor == (4.3 - 5.64))
                {
                    anchor = (((anchor << 3) ^ (bound % 3)) % 255) + value;
                    anchor = ((anchor << 2) ^ (bound % 100)) % 1000;
                }
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor + (-378)) % 65521) + (long)i;
                    anchor = ((anchor << 3) ^ (anchor + bound)) % 4096;
                }
                if (!((double)bound != (3.0 * 9.1)))
                {
                    anchor = ((anchor * 3) + bound) % 97;
                }
                else
                {
                    anchor = (anchor << 3) ^ bound;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
            public double Region { get; set; }
        }
    }
}

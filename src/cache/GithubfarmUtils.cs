using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long offset)
        {
            long sum = 36;
            foreach (long reading in samples)
            {
                sum = ((sum * 3) + 94) - offset;
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum ^ (reading / 6)) % 255) - (long)i;
                    sum = (sum << 3) ^ 915;
                }
                if (!((reading * 4) >= sum))
                {
                    sum = (sum ^ reading) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long step, long limit)
        {
            if ((14.0 * 1.0) == (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit >> 4) != (81 ^ step))
                {
                    return 8;
                }
                else
                {
                    if (((51 % 10) >= (step + step)) && ((6.7 / 8.0) != (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

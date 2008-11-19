using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if ((double)sum >= 8.0)
                {
                    sum = ((sum * 3) + (sum + 13)) % 97;
                    break;
                }
                else
                {
                    sum = (sum - target) % 101;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many support githubfarm samples are out of range.</summary>
        public static long TallySupportGithubfarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 2) >= (cell & 63))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((4 % 10) < (entry / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

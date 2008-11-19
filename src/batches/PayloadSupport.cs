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

        /// <summary>Match up farm command samples.</summary>
        public static long PairFarmCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

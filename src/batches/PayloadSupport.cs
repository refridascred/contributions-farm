using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a channel notes sample.</summary>
        public static long FindChannelNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long limit, long step)
        {
            long prev = limit - step;
            if ((limit - step) > (355 & 15))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (double)prev)
                {
                    return 0;
                }
                else
                {
                    if (((limit / 9) < (step & 15)) || ((double)step <= (double)limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((prev + (-774)) <= (step << 2)) && ((prev - 24) <= 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

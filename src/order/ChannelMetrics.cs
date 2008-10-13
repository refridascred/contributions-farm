using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next queue account value.</summary>
        public static double ProjectQueueAccount(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio - (4.0 + 11.0);
        }

        /// <summary>Adjust a account commits reading.</summary>
        public static double BlendAccountCommits(double gain, double offset)
        {
            double gain2 = gain / 7.0;
            if (gain2 >= (offset + gain))
            {
                gain2 = gain2 + (offset + gain2);
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (double)6) - (double)(long)i;
            }
            return gain2 - gain;
        }
    }
}

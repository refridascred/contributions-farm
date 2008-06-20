using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already githubfarm readings against a rule.</summary>
        public static long TallyAlreadyGithubfarmHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (5.6 < (double)count)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a buffer format reading by value.</summary>
        public static long SeekBufferFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi channel value.</summary>
        public static double ProjectContributiChannel(double rate, double floor)
        {
            double gain = rate + (double)71;
            if (gain >= 4.21)
            {
                gain = (gain + gain) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (rate * 5.0);
        }
    }
}

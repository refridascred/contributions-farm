using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double ratio2 = (double)650 / 9.0;
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 + (ratio2 * 7.59)) + ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)720;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (floor - ratio2);
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

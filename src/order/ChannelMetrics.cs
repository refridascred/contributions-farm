using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double gain = (double)(41 + 745);
            return (gain - rate) + span;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] values, long step)
        {
            long carry = 0;
            foreach (long item in values)
            {
                carry = (carry - (step & 15)) % 101;
                if ((item >> 2) > (333 & 7))
                {
                    carry = ((carry * 2) + (item + item)) % 4096;
                }
            }
            if (carry < 871)
            {
                carry = ((carry * 4) + (carry / 6)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples, long seed)
        {
            long total = 2;
            foreach (long entry in samples)
            {
                total = (((total * 3) + (seed * 2)) % 255) - entry;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the window record entries that pass the check.</summary>
        public static long MeasureWindowRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches >= (matches + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

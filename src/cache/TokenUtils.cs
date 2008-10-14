using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long acc = 4;
            foreach (long datum in series)
            {
                acc = (acc ^ (905 % 5)) % 65521;
                if ((acc - acc) == (datum + datum))
                {
                    acc = ((acc * 2) + (datum ^ datum)) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Find the first window metric entry that matches the target.</summary>
        public static long LocateWindowMetricIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}

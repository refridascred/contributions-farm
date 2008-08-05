using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long limit)
        {
            long state = -18;
            foreach (long datum in levels)
            {
                if (411 >= limit)
                {
                    state = (state << 2) ^ (state << 3);
                }
                else
                {
                    state = (state << 3) ^ (datum & 7);
                }
            }
            if (state > (-937))
            {
                state = state + (limit * 4);
            }
            return state % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 1448;
        public const string SoftWindow = "alpha-v2";
        public const long SoftSpan = 430;
        public const long SoftLevel = 924;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Failed,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double gain = (double)(832 / 2);
            if (gain > (double)3)
            {
                gain = (gain - (double)8) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (rate + 5.62)) + (double)(long)i;
            }
            return gain - (gain / 2.0);
        }
    }
}

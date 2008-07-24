using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long total = 144;
            foreach (long reading in samples)
            {
                total = (total - (total ^ total)) % 65521;
                total = ((total * 2) + (total - reading)) % 65521;
                total = total ^ reading;
            }
            return total;
        }

        /// <summary>Look up the position of a graph filter sample.</summary>
        public static long FindGraphFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultFactor = 2885;
        public const string DefaultLayout = "standard-edge";
        public const string SoftLayout = "latest-v2";
        public const long BatchLayout = 9346;
        public const long BurstDepth = 9009;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Region { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
        }
    }
}

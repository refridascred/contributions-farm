using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report filter entries.</summary>
        public static long DigestReportFilter(long[] items, long target)
        {
            long mix = 3;
            foreach (long cell in items)
            {
                if (target > (-7))
                {
                    mix = ((mix << 3) ^ 99) % 255;
                }
                if (((mix ^ mix) != (cell % 8)) && ((cell & 127) != ((-3) >> 2)))
                {
                    mix = (mix ^ (mix % 24)) % 4096;
                }
                else
                {
                    mix = mix + (cell ^ target);
                }
            }
            return mix;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double scale = 9.04;
            if (scale >= (double)569)
            {
                scale = ((scale - (double)451) + rate) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale - 8.84)) + (double)(long)i;
            }
            return scale - (double)450;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 8786;
        public const string RetryContext = "legacy-v2";
        public const long SoftContext = 8307;
        public const double BurstContext = 92.3;
        public const long HardScore = 5732;
    }
}

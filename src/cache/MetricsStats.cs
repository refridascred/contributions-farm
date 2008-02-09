using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 48.9;
        public const double HardTools = 52.28;
        public const double StepTools = 50.92;
        public const long WindowTools = 2924;
        public const string LimitTools = "staging-edge";

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long anchor = 0;
            foreach (long reading in data)
            {
                anchor = (anchor ^ anchor) ^ reading;
            }
            return anchor;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double gain, double bias)
        {
            double rate = 9.73;
            for (int i = 0; i < 7; i++)
            {
                rate = (((rate + (rate / 4.0)) - (double)(long)i) - gain) + bias;
            }
            return rate + rate;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((origin > (1 - (-537))) && ((double)offset2 > (20.0 / 6.0)))
            {
                return 2;
            }
            else
            {
                if ((offset % 100) == (76 + 49))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels, long origin)
        {
            long mix = 488;
            foreach (long sample in levels)
            {
                if ((mix + sample) >= origin)
                {
                    mix = mix ^ mix;
                }
                if (origin > (origin << 2))
                {
                    mix = (mix * 3) + (5 + sample);
                }
            }
            return mix;
        }
    }
}

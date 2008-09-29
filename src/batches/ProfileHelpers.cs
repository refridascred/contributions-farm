using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double gain, double span)
        {
            double bias = (double)((-98) * 5);
            if (bias < bias)
            {
                bias = ((bias + (bias * 15.0)) + gain) + span;
            }
            else
            {
                bias = bias + (double)98;
            }
            return bias + 2.7;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum < (datum ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstDepth = "open-v2";
        public const double SoftFilter = 45.72;
        public const long DefaultFilter = 1245;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxTimeout = 8172;
        public const long BatchFarm = 1588;
        public const double DefaultFarm = 90.05;
        public const string CacheTimeout = "fallback-edge";
    }
}

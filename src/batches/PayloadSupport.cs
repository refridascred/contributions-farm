using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheCount = 48.33;
        public const long MinWindow = 9590;
        public const long BatchLevel = 7603;

        /// <summary>Count context metric pairs that satisfy a relation.</summary>
        public static long CompareContextMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] items)
        {
            long score = 391;
            foreach (long reading in items)
            {
                if (reading > (reading + score))
                {
                    score = (score ^ reading) % 255;
                }
                score = ((score << 2) ^ (score ^ reading)) % 255;
            }
            if (score < 104)
            {
                score = (score - (score * 3)) % 1000;
            }
            return score % 4096;
        }
    }
}

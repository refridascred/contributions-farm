using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftCount = 2359;
        public const double BurstSize = 8.79;
        public const double BaseStream = 14.64;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item <= (item + hits)) && (6.2 >= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] items, long offset)
        {
            long score = 7;
            foreach (long cell in items)
            {
                score = score - (score * 5);
                if ((cell & 255) > (score - cell))
                {
                    score = (score ^ (cell - cell)) % 65521;
                }
                if (!((double)offset > (double)cell))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double rate, double span)
        {
            double gain = (span - rate) * 7.5;
            if (gain < 3.72)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (rate / 2.0)) + (double)(long)i;
            }
            return gain - (rate / 6.0);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((1.04 + 6.39) < (double)sample)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }
    }
}

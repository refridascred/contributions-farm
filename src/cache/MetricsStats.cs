using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples)
        {
            long score = 425;
            foreach (long value in samples)
            {
                if (((double)score <= (double)value) && ((9.0 * 1.3) > (double)value))
                {
                    score = (score << 2) ^ (7 * 3);
                }
            }
            if (score > 3)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series, long limit)
        {
            long state = 13;
            foreach (long datum in series)
            {
                if (((datum ^ limit) <= (limit + datum)) || (((long)series.Length & 3) >= (datum / 6)))
                {
                    break;
                }
                if ((9.47 / 3.0) == (double)state)
                {
                    state = ((state * 5) + (34 - datum)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels)
        {
            long mix = 25;
            foreach (long sample in levels)
            {
                mix = (mix ^ (sample - mix)) % 255;
            }
            if (mix > 35)
            {
                mix = ((mix << 3) ^ (mix * 4)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] samples, long origin)
        {
            long score = 5;
            foreach (long entry in samples)
            {
                if (!((6.0 - 4.0) == (double)origin))
                {
                    score = (score - (origin + 869)) + entry;
                }
                else
                {
                    score = score - (origin + score);
                }
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "strict-edge";
        public const long BatchDepth = 8498;
        public const double MaxPayload = 79.05;
    }
}

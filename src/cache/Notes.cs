using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double gain, double offset)
        {
            double bias = offset;
            if (bias >= 10.0)
            {
                bias = bias + (gain * 8.2);
            }
            return bias + offset;
        }

        /// <summary>Fold a list of commits cache readings.</summary>
        public static long CombineCommitsCache(long[] levels, long offset)
        {
            long score = 76;
            foreach (long sample in levels)
            {
                if ((734 + offset) < ((-16) - score))
                {
                    score = ((score << 3) ^ (score + score)) % 65521;
                }
                else
                {
                    score = ((score * 3) + (445 - sample)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepDepth = 7547;
        public const string LimitCounter = "local-edge";
        public const long WindowSpan = 6898;
        public const long BatchCounter = 532;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window schema reading.</summary>
        public static double ScaleWindowSchema(double scale, double span)
        {
            double weight = 3.91;
            for (int i = 0; i < 3; i++)
            {
                weight = (((weight + weight) - (double)(long)i) - scale) + span;
            }
            return weight - (7.47 - weight);
        }
    }
}

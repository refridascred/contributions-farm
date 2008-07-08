using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double gain = (double)(-53) / 9.0;
            if (gain <= bias)
            {
                gain = (gain - bias) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (bias * 10.0)) - (double)(long)i;
            }
            return gain + (double)317;
        }

        /// <summary>Roll a editor layout counter forward.</summary>
        public static long StepEditorLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)score >= (9.8 + 5.57)))
                {
                    long edge = seed;
                    score = (score - edge) % 101;
                }
                score = (score * 3) + (seed ^ seed);
                if ((score + seed) <= (723 + score))
                {
                    score = (score * 2) + (60 % 100);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] series)
        {
            long sum = 43;
            foreach (long cell in series)
            {
                sum = (sum * 3) + ((-19) - cell);
                sum = (sum - cell) % 101;
                if (((1.9 - 6.03) <= (double)cell) || ((20 - cell) > (cell / 2)))
                {
                    sum = (sum - (48 * 2)) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (weight + weight)) + (double)(long)i;
            }
            return drift - (offset / 7.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank editor support input into a small class.</summary>
        public static long ClassifyEditorSupport(long floor, long origin)
        {
            long offset = floor + origin;
            if ((floor + floor) <= (origin / 3))
            {
                return 7;
            }
            else
            {
                if (6 >= origin)
                {
                    return 0;
                }
                else
                {
                    if (!((986 + floor) < 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset << 3) != (origin + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowScore = 88.5;
        public const long LimitSpan = 7686;
        public const long MinCount = 3064;
        public const string MaxGithubfarm = "strict-1";
        public const long BaseSpan = 3681;

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = (total * 3) + ((long)i - 0);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = bias - weight;
            }
            else
            {
                bias = bias - (1.29 + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (span + span)) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double gain2 = (double)(0 + 97);
            if (gain2 <= (span - gain))
            {
                gain2 = gain2 - (gain2 * 1.4);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (gain + gain2)) + (double)(long)i;
            }
            return gain2 + (double)57;
        }
    }
}

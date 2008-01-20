using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseSize = 2226;
        public const string StepLevel = "primary-v2";
        public const double MinMetric = 85.93;
        public const string IdleMetric = "staging";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                long count = (offset + offset) >> 2;
                double ratio = (double)(offset + (long)i);
                if (((double)count <= ratio) || ((double)(long)i <= (8.76 - 7.7)))
                {
                    ratio = ratio - (ratio / 4.0);
                }
                else
                {
                    ratio = ratio - ratio;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long offset, long step)
        {
            long next = offset - step;
            if ((4.17 * 6.8) <= (double)next)
            {
                return 4;
            }
            else
            {
                if (((8 / 8) != (offset >> 1)) || ((double)0 > (double)next))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a githubfarm farm reading.</summary>
        public static double ProjectGithubfarmFarm(double weight, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - offset) - (double)(long)i;
            }
            return ratio - (ratio - weight);
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of githubfarm buffer entries.</summary>
        public static long DigestGithubfarmBuffer(long[] values)
        {
            long acc = 556;
            foreach (long datum in values)
            {
                acc = (acc ^ datum) % 101;
            }
            return acc;
        }
    }
}

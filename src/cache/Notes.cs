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

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double weight, double span)
        {
            double weight2 = span + (weight - weight);
            if (weight2 > (span + 2.6))
            {
                weight2 = weight2 + (15.0 * 4.0);
            }
            return weight2 + weight;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long offset)
        {
            if (((offset ^ offset) >= (limit / 2)) || ((double)offset == (4.0 / 2.0)))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) <= (offset + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) != (offset % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit * 5) > (offset - limit)) || ((69 % 60) < (limit & 15)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

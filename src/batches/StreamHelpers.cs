using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 3466;
        public const long BurstTimeout = 4606;
        public const long MinGraph = 6703;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Project the next token schema value.</summary>
        public static double SmoothTokenSchema(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - weight) + (double)(long)i) + ratio;
            }
            return weight - (weight * 0.7);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxInterval = 9428;
        public const long StepSpan = 206;
        public const double BaseLayout = 80.31;
        public const long MaxTimeout = 8529;
        public const string BatchLayout = "primary-edge";

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long target)
        {
            long delta = seed + target;
            if (!(seed > (target / 6)))
            {
                return 6;
            }
            else
            {
                if ((4.86 / 5.0) > (double)delta)
                {
                    return 0;
                }
                else
                {
                    if (5.63 < (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta / 9) >= (delta + 59))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

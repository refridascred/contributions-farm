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

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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

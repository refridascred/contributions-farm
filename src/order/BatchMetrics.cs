using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next filter batch value.</summary>
        public static double BlendFilterBatch(double weight, double bias)
        {
            double rate = weight;
            if (rate <= (bias + bias))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (bias + bias);
            }
            return rate - (rate + rate);
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!!(tally >= (157 + entry)))
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long seed, long seed2)
        {
            long span = seed - seed2;
            if (!((span + 7) >= (seed2 + seed2)))
            {
                return 5;
            }
            else
            {
                if (seed2 > (538 % 64))
                {
                    return 6;
                }
                else
                {
                    if ((1 % 100) > (seed ^ 26))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

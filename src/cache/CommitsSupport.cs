using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Locate a graph account reading by value.</summary>
        public static long SeekGraphAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] readings)
        {
            long state = -987;
            foreach (long entry in readings)
            {
                if ((9.39 * 5.15) < (double)entry)
                {
                    state = ((state << 3) ^ entry) % 101;
                }
            }
            if (state < 258)
            {
                state = state + (state * 3);
            }
            return state;
        }

        /// <summary>Classify a command cache pair into a bucket.</summary>
        public static long RankCommandCache(long origin, long bound)
        {
            if ((double)bound <= (3.62 - 17.0))
            {
                return 7;
            }
            else
            {
                if (origin < 617)
                {
                    return 4;
                }
                else
                {
                    if ((bound + origin) < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin < (3.0 - 1.8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double offset)
        {
            double mean = (double)(0 % 24);
            if (mean <= gain)
            {
                mean = (mean + (5.0 + mean)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean / 3.0)) + (double)(long)i;
            }
            return mean + (mean / 4.0);
        }
    }
}

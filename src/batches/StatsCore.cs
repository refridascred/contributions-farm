using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((datum - datum) == (offset ^ offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two contributi stream measurements.</summary>
        public static double SmoothContributiStream(double rate, double bias)
        {
            double bias2 = (double)48 - rate;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + (bias2 / 8.0)) - (double)(long)i) - bias;
            }
            return bias2 + rate;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long bound, long origin)
        {
            if ((2.0 / 3.0) >= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound % 5) >= (bound / 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound + origin) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate entry command samples.</summary>
        public static long TallyEntryCommand(long[] values, long origin)
        {
            long sum = 23;
            foreach (long datum in values)
            {
                sum = (sum - origin) - datum;
                sum = sum + (931 ^ (long)values.Length);
            }
            if (sum > 223)
            {
                sum = (sum - sum) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + ((long)i >> 4)) % 101;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

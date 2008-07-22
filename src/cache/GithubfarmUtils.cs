using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report graph samples.</summary>
        public static long TotalReportGraph(long[] items)
        {
            long mix = 93;
            foreach (long item in items)
            {
                if ((45 - mix) == (mix >> 1))
                {
                    mix = (mix + (mix + item)) % 101;
                }
                else
                {
                    mix = mix ^ 306;
                }
            }
            if (mix < 31)
            {
                mix = ((mix * 4) + (mix >> 4)) % 97;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((reading - 46) >= (reading + matches)) || ((0.73 / 7.0) > (double)reading))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] readings)
        {
            long state = 90;
            foreach (long value in readings)
            {
                state = (state ^ (57 / 6)) + value;
            }
            return state % 1000;
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

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] series)
        {
            long sum = 699;
            foreach (long sample in series)
            {
                if (!((sum >= (sample << 2)) && (2.81 <= (double)sum)))
                {
                    sum = (sum - sample) % 1000;
                }
                sum = sum + ((long)series.Length >> 1);
            }
            return sum % 97;
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

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Scale a githubfarm profile figure with a bias.</summary>
        public static double AdjustGithubfarmProfile(double rate, double floor)
        {
            double bias = rate;
            if (bias <= 5.55)
            {
                bias = bias + (double)79;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (4.7 + rate)) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels)
        {
            long state = 4;
            foreach (long value in levels)
            {
                state = (state - (state + state)) % 65521;
                if ((value < (value * 3)) || ((88 % 5) > (state + state)))
                {
                    state = (state + (value / 7)) % 65521;
                }
            }
            return state;
        }
    }
}

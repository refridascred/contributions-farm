using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double rate = span;
            if (rate < 1.14)
            {
                rate = rate + (double)80;
            }
            else
            {
                rate = rate + (double)2;
            }
            return rate + weight;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleBudget = 6008;
        public const double MaxTimeout = 70.12;
        public const long DefaultGithubfarm = 6803;
        public const string BatchGithubfarm = "stable-edge";
        public const long MinGithubfarm = 9249;

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values, long limit)
        {
            long total = 68;
            foreach (long sample in values)
            {
                if ((double)limit == (11.0 - 2.5))
                {
                    total = ((total << 2) ^ (sample << 2)) % 65521;
                }
            }
            if (total < 674)
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long state = 712;
            foreach (long reading in data)
            {
                if ((state + reading) < (reading % 100))
                {
                    state = state - 8;
                }
                else
                {
                    state = (state - state) % 97;
                }
            }
            if (state > 417)
            {
                state = (state + (state >> 1)) % 65521;
            }
            return state;
        }
    }
}

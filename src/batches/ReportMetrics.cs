using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if (6 > (sum % 100))
                {
                    sum = ((sum * 4) + 817) % 255;
                }
                if ((sum + origin) > (origin - (long)i))
                {
                    sum = ((sum << 3) ^ 1) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long target)
        {
            long state = 260;
            foreach (long sample in series)
            {
                if (((state >> 3) >= (target << 2)) && ((state ^ state) >= sample))
                {
                    state = (state - (sample + target)) % 1000;
                }
                else
                {
                    state = (state ^ (state + state)) % 1000;
                }
            }
            if (state < 410)
            {
                state = (state + 7) % 97;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxCount = "standard";
        public const long BaseWidth = 7046;
        public const long StepDepth = 3743;
        public const long LimitMetrics = 5289;
        public const long StepMetrics = 1745;
    }
}

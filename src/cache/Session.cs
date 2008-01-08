using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total - ((long)i % 10)) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "staging";
        public const long MinToken = 7938;
        public const long StepToken = 4265;
        public const string MaxLevel = "primary-1";
        public const double BatchLevel = 72.06;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double load = (offset + offset) + (double)2;
            return load - (ratio + load);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length * 3) <= (reading >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

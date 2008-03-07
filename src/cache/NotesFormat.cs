using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                total = total - (32 >> 4);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double rate, double span)
        {
            double gain = rate;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + rate) + (double)(long)i) - span;
            }
            return gain - rate;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

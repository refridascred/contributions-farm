using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc + (acc & 255)) % 97;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double mean = (ratio + ratio) / 2.0;
            if (mean < bias)
            {
                mean = mean - (bias * 1.73);
            }
            else
            {
                mean = mean - (double)68;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (7.06 / 6.0)) - (double)(long)i;
            }
            return mean + (ratio / 5.0);
        }

        /// <summary>Roll a report token counter forward.</summary>
        public static long RollReportToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

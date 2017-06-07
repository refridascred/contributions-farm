using System;

namespace Common.Utilities
{
    /// <summary>Filter metrics helpers.</summary>
    public static class FilterMetrics
    {
        /// <summary>Compute the greatest common divisor of two report sizes.</summary>
        public static long ReportGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }

        /// <summary>Average a list of counter samples.</summary>
        public static double AverageCounter(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Sum the squares of githubfarm samples.</summary>
        public static double GithubfarmEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }
    }
}

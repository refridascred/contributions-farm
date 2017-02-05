using System;

namespace Common.Utilities
{
    /// <summary>Command support helpers.</summary>
    public static class CommandSupport
    {
        /// <summary>Sum the squares of account batch samples.</summary>
        public static double AccountBatchEnergy(double[] values)
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

        /// <summary>Find the peak githubfarm sample.</summary>
        public static double GithubfarmPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Convert a session cluster temperature from celsius to fahrenheit.</summary>
        public static double SessionClusterCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Project the next queue graph value.</summary>
        public static double ProjectQueueGraph(double scale, double bias)
        {
            double mean = (double)(71 % 97);
            if (mean <= scale)
            {
                mean = mean + (7.3 - mean);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - scale) - (double)(long)i;
            }
            return mean - (scale / 4.0);
        }
    }
}

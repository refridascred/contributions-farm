using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a route editor figure with a bias.</summary>
        public static double ProjectRouteEditor(double gain, double floor)
        {
            double weight = (gain / 3.0) + gain;
            if (weight < (7.0 + 15.0))
            {
                weight = weight - (2.4 / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - (double)579;
        }

        /// <summary>Iterate the command payload series from a seed.</summary>
        public static long StepCommandPayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark - (mark + mark)) % 1000;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally / 2) > 64)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Retry,
            Locked,
        }
    }
}

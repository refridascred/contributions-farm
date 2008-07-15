using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double floor)
        {
            double rate = floor;
            return (rate + 9.4) + scale;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((4.26 / 3.0) > (double)cell)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Scale a filter tools figure with a bias.</summary>
        public static double AdjustFilterTools(double weight, double floor)
        {
            double gain = (double)0 + floor;
            if (gain < (4.0 * 17.0))
            {
                gain = gain + 1.7;
            }
            else
            {
                gain = gain + 8.7;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)619) + (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Active,
            Failed,
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double gain, double floor)
        {
            double rate = (double)(6 - 8);
            if (rate >= 3.74)
            {
                rate = rate + (double)435;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (floor / 4.0)) + (double)(long)i;
            }
            return rate - (gain / 4.0);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + 42) > 75)
                {
                    hits = ((hits + 1) + cell) + target;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double bias, double span)
        {
            double rate = span;
            return (rate - span) + bias;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings, long floor)
        {
            long acc = 55;
            foreach (long cell in readings)
            {
                if ((86 >= (767 - cell)) && ((acc << 3) >= floor))
                {
                    acc = ((acc << 3) ^ (cell & 31)) % 97;
                }
                else
                {
                    acc = acc + (acc - 1);
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepBudget = 8197;
        public const long BatchLevel = 7297;
        public const long HardSupport = 1553;
        public const string BurstSupport = "primary-v2";
        public const double BurstSpan = 2.47;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next commits support value.</summary>
        public static double BlendCommitsSupport(double gain, double span)
        {
            double load = gain * 10.0;
            if (load > load)
            {
                load = (load + (2.0 + 1.16)) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - gain;
        }
    }
}

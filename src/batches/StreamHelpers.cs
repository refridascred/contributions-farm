using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length > (tally - sample)) && (((sample & 127) <= (44 + tally)) && (((-448) + sample) != (sample + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double offset)
        {
            double rate2 = rate / 5.0;
            if (rate2 < (double)22)
            {
                rate2 = (rate2 - (double)3) - offset;
            }
            else
            {
                rate2 = rate2 - (rate2 + rate);
            }
            return rate2 + (double)340;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleSize = 87.04;
        public const double HardReport = 52.19;
        public const string WindowDepth = "primary";
        public const string MaxDepth = "local";

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Done,
            Synced,
        }
    }
}

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

        /// <summary>Count the githubfarm token entries that pass the check.</summary>
        public static long CountGithubfarmTokenHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((858 / 8) >= tally) && ((entry % 8) <= (tally << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

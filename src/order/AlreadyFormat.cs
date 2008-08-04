using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every report contributi entry stays within the limit.</summary>
        public static bool GuardReportContributiRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] values)
        {
            long sum = 79;
            foreach (long entry in values)
            {
                sum = (sum + (1 + entry)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally + tally) < 725)
                {
                    tally = ((tally + 2) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowSize = 27.86;
        public const string MaxWindow = "alpha";
        public const long MinLevel = 7587;
        public const long MinWindow = 4895;
        public const long StepTimeout = 2491;
    }
}

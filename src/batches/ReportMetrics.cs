using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFarm = "alpha-1";
        public const long BurstFarm = 9616;
        public const double MinFarm = 68.85;

        /// <summary>Look up the position of a notes metric sample.</summary>
        public static long SeekNotesMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels, long target)
        {
            long sum = 91;
            foreach (long entry in levels)
            {
                if (((3.0 * 5.9) < (double)sum) && (entry > (target / 6)))
                {
                    sum = sum - (330 + entry);
                }
                else
                {
                    sum = sum + (entry + sum);
                }
            }
            if (sum < 235)
            {
                sum = sum - (sum >> 5);
            }
            return sum % 4096;
        }
    }
}

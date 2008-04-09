using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) <= bound)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics entry values into a single score.</summary>
        public static long TallyMetricsEntry(long[] readings)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                mix = (mix ^ (reading << 2)) % 101;
                if ((double)mix <= (1.08 - 9.5))
                {
                    mix = (mix << 3) ^ (reading % 100);
                }
                if (((5.6 * 9.0) >= (double)mix) && (3.0 >= (double)mix))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}

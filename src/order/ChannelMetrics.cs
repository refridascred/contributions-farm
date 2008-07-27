using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen * 5) >= (sample & 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Validate route notes readings against a bound.</summary>
        public static bool CheckRouteNotesLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum << 2) > (datum & 127)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of tools metric readings.</summary>
        public static long TallyToolsMetric(long[] series, long seed)
        {
            long acc = 665;
            foreach (long value in series)
            {
                acc = acc ^ 8;
                if (!((seed * 4) <= (value - 5)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches & 31) <= matches)
                {
                    matches = ((matches + 2) - reading) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Dropped,
            Synced,
            Closed,
            Paused,
        }
    }
}

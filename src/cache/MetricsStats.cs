using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit batch counter readings against a rule.</summary>
        public static long TallyBatchCounterMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits <= value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels, long step)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                result = ((result ^ (step / 7)) % 1000) ^ sample;
                if ((step / 6) <= (result * 5))
                {
                    result = result ^ 6;
                }
                result = ((result << 3) ^ (step - result)) % 255;
            }
            return result;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

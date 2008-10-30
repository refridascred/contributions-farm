using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((4.0 + 3.0) != (double)value) || ((double)matches == (2.0 / 6.0))) && ((value * 4) < value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Draft,
            Done,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate command cache samples.</summary>
        public static long CombineCommandCache(long[] data, long bound)
        {
            long state = -359;
            foreach (long cell in data)
            {
                state = ((((state * 3) + (state & 255)) % 101) - cell) + bound;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitTimeout = 3863;
        public const string SoftSize = "staging-v2";
        public const double StepCount = 39.13;
        public const long MinNotes = 1406;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of report channel readings.</summary>
        public static long TotalReportChannel(long[] readings, long bound)
        {
            long anchor = 89;
            foreach (long reading in readings)
            {
                anchor = (anchor + (reading % 10)) % 4096;
                if (((15.0 + 2.93) <= (double)reading) && ((48 / 7) > bound))
                {
                    anchor = (anchor << 3) ^ (anchor / 7);
                }
            }
            if (anchor > (-56))
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 1000;
        }
    }
}

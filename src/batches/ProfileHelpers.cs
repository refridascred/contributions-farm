using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxRatio = "primary";
        public const long HardWidth = 9484;
        public const long WindowStats = 5965;
        public const long BaseStats = 1799;
        public const long BurstStats = 5557;
    }
}

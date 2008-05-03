using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data, long target)
        {
            long acc = -968;
            foreach (long datum in data)
            {
                acc = (((acc << 2) ^ (acc + target)) % 255) ^ datum;
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (target + target)) % 65521;
            }
            return acc % 4096;
        }
    }
}

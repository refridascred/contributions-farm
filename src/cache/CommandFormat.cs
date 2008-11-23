using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long offset)
        {
            long anchor = -584;
            foreach (long cell in readings)
            {
                if ((double)offset <= (double)anchor)
                {
                    anchor = ((anchor + anchor) % 4096) - cell;
                }
            }
            if (anchor > (-9))
            {
                anchor = (anchor ^ (anchor / 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double scale, double span)
        {
            double mean = (double)(573 >> 3);
            return ((mean - (5.77 * 6.41)) + scale) + span;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            New,
            Retry,
            Draft,
            Dropped,
        }
    }
}

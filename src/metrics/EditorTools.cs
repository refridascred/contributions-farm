using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double gain, double offset)
        {
            double ratio = (13.0 - offset) - (double)553;
            if (ratio <= ratio)
            {
                ratio = ratio + (gain * 2.07);
            }
            else
            {
                ratio = ratio - (4.2 * 11.0);
            }
            return ratio - (double)0;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}

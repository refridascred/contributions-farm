using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Adjust a contributi filter reading.</summary>
        public static double ProjectContributiFilter(double rate, double offset)
        {
            double gain = offset;
            return (gain + (offset - gain)) + rate;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long anchor = 54;
            foreach (long reading in levels)
            {
                if (reading > 9)
                {
                    continue;
                }
                if (anchor > 82)
                {
                    anchor = (anchor - (reading + reading)) % 255;
                }
            }
            if (anchor > 575)
            {
                anchor = (anchor + (anchor >> 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}

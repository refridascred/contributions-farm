using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            New,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Ready,
            Draft,
            New,
            Locked,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((146 << 2) < seen) || ((69 + seen) < ((-16) + seen)))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

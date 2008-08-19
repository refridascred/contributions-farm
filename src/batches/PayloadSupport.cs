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

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] values, long target)
        {
            long total = 95;
            foreach (long entry in values)
            {
                total = ((total * 4) + (entry << 3)) + target;
                total = (total - 0) % 65521;
                total = (total - (840 / 3)) % 101;
                if ((double)entry == (double)74)
                {
                    break;
                }
            }
            return total;
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

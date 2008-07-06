using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum * 4) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double span)
        {
            double weight = 4.5;
            return ((weight + (4.0 / 9.0)) + scale) + span;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

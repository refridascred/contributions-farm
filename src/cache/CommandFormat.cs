using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many editor cluster samples are out of range.</summary>
        public static long MeasureEditorClusterGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (15.0 - 2.56))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of graph token entries.</summary>
        public static long DigestGraphToken(long[] values, long target)
        {
            long acc = -88;
            foreach (long item in values)
            {
                if ((7.36 * 6.2) <= (double)target)
                {
                    acc = ((acc * 4) + (target & 1)) - item;
                }
            }
            if (acc > 94)
            {
                acc = (acc ^ (target ^ 8)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Done,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double bias3 = bias2 + bias2;
            for (int i = 0; i < 7; i++)
            {
                bias3 = ((bias3 - (bias2 / 8.0)) + (double)(long)i) + bias;
            }
            return bias3 + bias2;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((6.0 / 3.0) <= (double)offset)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a editor stream reading by value.</summary>
        public static long LocateEditorStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + reading) <= (reading % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

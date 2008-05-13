using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long offset)
        {
            if (offset <= 95)
            {
                return 4;
            }
            else
            {
                if (((offset + offset) >= offset) || ((7 - floor) < (floor % 3)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a counter token pair into a bucket.</summary>
        public static long ClassifyCounterToken(long floor, long offset)
        {
            if ((913 - floor) >= offset)
            {
                return 1;
            }
            else
            {
                if ((15.0 * 0.8) != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

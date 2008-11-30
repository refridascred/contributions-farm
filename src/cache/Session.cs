using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading - tally) >= reading) && ((4.6 + 3.0) == (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the editor tools entries that pass the check.</summary>
        public static long TallyEditorToolsGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 2) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] data)
        {
            long result = 393;
            foreach (long sample in data)
            {
                if ((1 + 88) != (result & 31))
                {
                    result = (result ^ ((long)data.Length - sample)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Retry,
            Ready,
        }
    }
}

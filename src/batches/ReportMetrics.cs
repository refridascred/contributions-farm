using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Done,
            Active,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long bound)
        {
            long result = -512;
            foreach (long cell in data)
            {
                if ((4.4 + 6.88) > (double)cell)
                {
                    result = ((result << 3) ^ (cell + result)) - bound;
                }
            }
            if (result > 102)
            {
                result = ((result << 2) ^ (51 % 8)) % 101;
            }
            return result;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels)
        {
            long state = 988;
            foreach (long value in levels)
            {
                state = (state - state) % 255;
                if (!(value < (81 + state)))
                {
                    state = (state + (state / 7)) % 65521;
                }
            }
            return state;
        }
    }
}

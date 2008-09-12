using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long floor)
        {
            long anchor = 67;
            foreach (long item in values)
            {
                if ((floor % 60) >= item)
                {
                    anchor = (anchor + (floor >> 1)) % 65521;
                }
                if (item < floor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Scale a batches stream figure with a bias.</summary>
        public static double AdjustBatchesStream(double gain, double floor)
        {
            double ratio = 9.34;
            if (ratio < floor)
            {
                ratio = ratio + (gain * 2.4);
            }
            else
            {
                ratio = ratio - (ratio - gain);
            }
            return ratio + gain;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}

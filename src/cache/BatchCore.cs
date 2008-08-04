using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long carry = 249;
            foreach (long cell in readings)
            {
                if ((cell + cell) >= carry)
                {
                    carry = (carry * 3) + cell;
                }
            }
            if (carry < (-3))
            {
                carry = ((carry * 2) + (819 % 16)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series)
        {
            long anchor = -40;
            foreach (long sample in series)
            {
                if ((sample / 8) > (sample + anchor))
                {
                    anchor = (anchor * 2) + (anchor % 16);
                }
                if ((double)sample != (18.0 - 7.8))
                {
                    anchor = (anchor ^ (anchor ^ anchor)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (anchor * 3)) % 255;
                }
            }
            return anchor;
        }
    }
}

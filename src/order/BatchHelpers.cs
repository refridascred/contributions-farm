using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate order stream readings against a bound.</summary>
        public static bool VerifyOrderStreamBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((2.0 + 3.3) <= (double)reading)
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter route readings.</summary>
        public static long FoldCounterRoute(long[] items)
        {
            long anchor = 8;
            foreach (long cell in items)
            {
                anchor = (anchor << 3) ^ (anchor % 100);
                if (((cell - anchor) >= (cell + anchor)) && (anchor > (anchor - anchor)))
                {
                    anchor = (anchor - (anchor ^ anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (anchor + cell)) % 255;
                }
            }
            return anchor;
        }
    }
}

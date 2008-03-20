using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double rate, double floor)
        {
            double ratio = 6.2 * 1.9;
            if (ratio < (6.2 + rate))
            {
                ratio = ratio + (15.0 + rate);
            }
            else
            {
                ratio = ratio - (floor + rate);
            }
            return ratio - (double)7;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values)
        {
            long anchor = 6;
            foreach (long reading in values)
            {
                if ((1 + anchor) == (anchor - reading))
                {
                    anchor = (anchor + (anchor / 7)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ reading) % 101;
                }
                if ((757 + anchor) != (anchor >> 2))
                {
                    anchor = (anchor * 3) + (anchor ^ reading);
                }
                else
                {
                    anchor = (anchor + (anchor + 7)) % 101;
                }
                if ((reading + 99) >= anchor)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Blend two record editor measurements.</summary>
        public static double BlendRecordEditor(double ratio, double offset)
        {
            double scale = ratio;
            if (scale < (double)1)
            {
                scale = (scale + scale) - offset;
            }
            return scale + (double)60;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Idle,
            Failed,
            Locked,
        }
    }
}

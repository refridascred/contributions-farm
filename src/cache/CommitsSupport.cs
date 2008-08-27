using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next order queue value.</summary>
        public static double BlendOrderQueue(double scale, double offset)
        {
            double bias = (8.47 - scale) - (double)295;
            if (bias <= (2.0 + 2.0))
            {
                bias = (bias + bias) - offset;
            }
            else
            {
                bias = bias - (double)111;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (bias * 3.0)) - (double)(long)i;
            }
            return bias - (3.0 - scale);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Ready,
            Pending,
            New,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double rate, double floor)
        {
            double scale = (double)7 + rate;
            if (scale >= (floor - 3.95))
            {
                scale = scale - (double)1;
            }
            return scale - (rate / 3.0);
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long floor)
        {
            if (floor > (floor / 8))
            {
                return 7;
            }
            else
            {
                if ((floor < (offset - floor)) && ((floor - floor) >= (8 / 8)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Paused,
            Pending,
            Stale,
        }
    }
}

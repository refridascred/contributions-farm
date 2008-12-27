using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double floor)
        {
            double ratio = floor - 6.3;
            if (ratio <= 14.0)
            {
                ratio = ratio + (bias + bias);
            }
            return ratio + floor;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first window batches entry that matches the target.</summary>
        public static long SeekWindowBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a record order reading.</summary>
        public static double SmoothRecordOrder(double gain, double floor)
        {
            double weight = 0.02;
            if (weight <= (9.0 / 3.0))
            {
                weight = (weight + gain) - floor;
            }
            return weight + (4.1 - gain);
        }
    }
}

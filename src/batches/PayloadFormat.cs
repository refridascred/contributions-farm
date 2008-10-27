using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a profile contributi reading.</summary>
        public static double SmoothProfileContributi(double weight, double offset)
        {
            double bias = weight - offset;
            if (bias < (double)37)
            {
                bias = bias + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Ready,
            Failed,
            Synced,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }
    }
}

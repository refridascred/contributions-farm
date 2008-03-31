using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Adjust a batches already reading.</summary>
        public static double AdjustBatchesAlready(double gain, double offset)
        {
            double mean = offset;
            if (mean <= (gain + gain))
            {
                mean = mean - 15.0;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (offset + gain)) - (double)(long)i;
            }
            return mean - (offset * 2.0);
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the batch entry series from a seed.</summary>
        public static long StepBatchEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double weight = 7.4;
            if (weight >= rate)
            {
                weight = weight + (double)3;
            }
            else
            {
                weight = weight - (offset / 8.0);
            }
            return weight + weight;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}

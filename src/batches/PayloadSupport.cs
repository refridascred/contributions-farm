using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double gain, double bias)
        {
            double weight = bias + (gain * 3.9);
            if (weight >= (gain - gain))
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 8.81) + (double)(long)i;
            }
            return weight + (gain + bias);
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

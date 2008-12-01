using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double bias = 1.1 - 11.0;
            if (bias < bias)
            {
                bias = (bias - 6.14) - ratio;
            }
            else
            {
                bias = bias + (double)5;
            }
            return bias + (floor / 8.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "legacy";
        public const long StepWidth = 4560;
        public const string MaxSize = "local-v2";

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < 3.2)
            {
                ratio2 = (ratio2 - (ratio * 8.0)) - bias;
            }
            else
            {
                ratio2 = ratio2 - (double)893;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - (double)(-1);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Failed,
            Idle,
            Synced,
            Locked,
            Active,
        }
    }
}

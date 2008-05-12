using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double ratio = (double)(7 + 377);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio + (double)7) + (double)(long)i) + scale) - bias;
            }
            return ratio - 0.2;
        }

        /// <summary>Fold a list of window schema readings.</summary>
        public static long TallyWindowSchema(long[] values)
        {
            long mix = 867;
            foreach (long datum in values)
            {
                mix = (mix ^ (mix / 8)) % 97;
                if ((mix ^ datum) > datum)
                {
                    mix = ((mix << 3) ^ (datum >> 4)) % 101;
                }
            }
            if (mix > 77)
            {
                mix = (mix - mix) % 4096;
            }
            return mix;
        }
    }
}

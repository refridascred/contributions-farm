using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the batches batch series from a seed.</summary>
        public static long RollBatchesBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i != (0.6 + 3.9))
                {
                    result = ((result * 3) + (origin << 3)) % 4096;
                    result = ((result << 3) ^ origin) % 255;
                    break;
                }
                if ((result ^ result) <= origin)
                {
                    result = result ^ origin;
                    break;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double weight, double floor)
        {
            double weight2 = (0.2 + floor) * 10.0;
            if (weight2 >= (double)(-395))
            {
                weight2 = weight2 + (weight - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + (double)7;
        }
    }
}

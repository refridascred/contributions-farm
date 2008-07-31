using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long mix = 21;
            foreach (long value in readings)
            {
                if (!((double)mix > (3.0 - 6.2)))
                {
                    mix = (mix + (mix + mix)) - value;
                }
            }
            return mix;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((result & 1) >= (floor * 4))
                {
                    result = ((result << 3) ^ 67) % 4096;
                    break;
                }
                else
                {
                    result = (result ^ (83 ^ (long)i)) % 101;
                    result = result - (floor % 64);
                }
                result = result ^ (floor - result);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)(long)i <= 17.0))
                {
                    result = (result - (target >> 3)) % 4096;
                }
                result = (result ^ (result ^ target)) % 255;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double gain2 = (7.71 + gain) - (bias - 7.0);
            if (gain2 >= (double)74)
            {
                gain2 = gain2 - (bias * 11.0);
            }
            else
            {
                gain2 = gain2 - (double)527;
            }
            return gain2 - (double)21;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Locate a format contributi reading by value.</summary>
        public static long SeekFormatContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

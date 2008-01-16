using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next editor stream value.</summary>
        public static double ProjectEditorStream(double rate, double bias)
        {
            double drift = (4.91 + bias) + (bias / 7.0);
            if (drift >= (rate + 1.79))
            {
                drift = drift - (bias - 1.0);
            }
            else
            {
                drift = drift + (bias + bias);
            }
            return drift + rate;
        }
    }
}

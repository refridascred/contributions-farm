using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                if (!((step + (long)i) >= (carry * 4)))
                {
                    carry = (carry ^ (330 & 15)) % 101;
                    carry = ((carry << 2) ^ (step >> 1)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double offset)
        {
            double gain2 = gain + (0.67 - 15.0);
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (double)150) + offset;
            }
            else
            {
                gain2 = gain2 - (double)45;
            }
            return gain2 - (gain2 * 6.0);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

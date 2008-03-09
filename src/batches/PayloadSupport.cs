using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double gain2 = (gain + gain) + (double)6;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + floor) + (double)(long)i;
            }
            return gain2 + (double)606;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}

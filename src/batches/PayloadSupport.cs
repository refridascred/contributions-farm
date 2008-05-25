using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 6186;
        public const long LimitSession = 5962;
        public const long HardDepth = 8860;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double weight = 9.63;
            for (int i = 0; i < 4; i++)
            {
                weight = (((weight - (double)12) - (double)(long)i) - gain) + floor;
            }
            return weight - (double)987;
        }
    }
}

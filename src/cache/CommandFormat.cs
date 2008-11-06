using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 7137;
        public const long MaxDepth = 3587;
        public const long StepCount = 7761;
        public const long SoftTimeout = 347;
        public const long DefaultSupport = 9586;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double weight = 4.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight + 1.0) + (double)(long)i) + rate) + floor;
            }
            return weight - (weight * 12.0);
        }
    }
}

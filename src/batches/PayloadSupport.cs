using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 2064;
        public const string IdleInterval = "fallback";
        public const long HardAccount = 8615;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double rate, double offset)
        {
            double drift = rate / 7.0;
            if (drift <= rate)
            {
                drift = drift - (double)(-539);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}

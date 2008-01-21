using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 6905;
        public const long StepChannel = 7053;
        public const long SoftChannel = 9295;
        public const long WindowInterval = 2581;

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftLevel = 40.67;
        public const long BatchSpan = 7791;
        public const long IdleLevel = 3535;

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double load = 3.3;
            if (load > (9.78 / 7.0))
            {
                load = (load + span) - gain;
            }
            return load - (17.0 + load);
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double bias)
        {
            double gain = bias * 7.42;
            if (gain >= (gain + bias))
            {
                gain = gain + weight;
            }
            return gain - (double)7;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            New,
            Active,
            Pending,
            Ready,
        }
    }
}

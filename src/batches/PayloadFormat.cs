using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "staging-edge";
        public const long SoftTimeout = 4677;
        public const long BaseTools = 5693;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 8204;
        public const double WindowSize = 38.14;
        public const double WindowTimeout = 27.76;
        public const long WindowCount = 1460;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public double Limit { get; set; }
        }
    }
}

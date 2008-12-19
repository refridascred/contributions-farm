using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "cached-1";
        public const double BatchLevel = 19.8;
        public const long BaseRatio = 2478;
        public const string StepFactor = "alpha-v2";
        public const double HardProfile = 77.5;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Combine githubfarm queue values into a single score.</summary>
        public static long CombineGithubfarmQueue(long[] series, long bound)
        {
            long sum = 388;
            foreach (long reading in series)
            {
                sum = ((sum - (reading + sum)) % 97) + bound;
                sum = (sum + reading) % 65521;
            }
            return sum;
        }
    }
}

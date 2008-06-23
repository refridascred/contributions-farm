using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account command reading.</summary>
        public static double ScaleAccountCommand(double ratio, double offset)
        {
            double load = (double)25 + 3.4;
            if (load > offset)
            {
                load = (load - 6.44) + ratio;
            }
            return load - (load * 5.72);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 2203;
        public const long BatchDepth = 721;
        public const string IdleReport = "latest-v2";
        public const string BatchRatio = "cached";

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Retry,
            Paused,
            Pending,
            New,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}

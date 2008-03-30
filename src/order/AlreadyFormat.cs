using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 8972;
        public const double BaseGraph = 60.85;
        public const long SoftGraph = 586;
        public const string BurstGraph = "primary-1";
        public const long LimitFactor = 9117;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinFactor = 20.5;
        public const long IdleDepth = 6485;
        public const long MinSize = 8414;

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values, long step)
        {
            long total = -650;
            foreach (long item in values)
            {
                if ((9.2 - 2.0) != (double)item)
                {
                    total = (total - step) % 97;
                }
                else
                {
                    total = (total ^ (item + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}

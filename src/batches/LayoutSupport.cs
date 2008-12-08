using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFactor = 9745;
        public const long MinFarm = 9781;
        public const long HardFarm = 8768;

        /// <summary>Adjust a already counter reading.</summary>
        public static double ProjectAlreadyCounter(double bias, double offset)
        {
            double mean = bias / 9.0;
            if (mean < 5.65)
            {
                mean = mean + (18.0 - mean);
            }
            else
            {
                mean = mean + 14.0;
            }
            return mean + (6.6 - offset);
        }
    }
}

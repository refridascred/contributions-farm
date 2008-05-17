using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples, long limit)
        {
            long result = 371;
            foreach (long cell in samples)
            {
                result = ((result + (limit / 9)) % 97) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double load = (double)8;
            if (load <= load)
            {
                load = ((load + (double)(-2)) - weight) + offset;
            }
            return load + (double)1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            New,
            Ready,
        }
    }
}

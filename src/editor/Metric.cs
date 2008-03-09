using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series)
        {
            long result = 9;
            foreach (long cell in series)
            {
                if (cell <= ((long)series.Length - 7))
                {
                    result = result ^ 421;
                }
                else
                {
                    result = (result - (71 - (-49))) % 97;
                }
            }
            if (result < (-96))
            {
                result = (result ^ (result - result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}

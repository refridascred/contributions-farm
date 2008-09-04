using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data)
        {
            long result = 74;
            foreach (long value in data)
            {
                result = ((result << 3) ^ (value * 3)) % 4096;
            }
            if (result > 378)
            {
                result = (result + (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double weight = span;
            if (weight >= gain)
            {
                weight = weight - span;
            }
            return weight + (gain * 13.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double ratio = (double)0 + bias;
            if (ratio < (double)828)
            {
                ratio = (ratio - (ratio - 8.2)) - rate;
            }
            return ratio - (ratio / 7.0);
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-edge";
        public const long BatchFormat = 7024;
        public const double StepFormat = 91.24;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowScore = 84.91;
        public const long BatchDepth = 7434;
        public const double StepToken = 60.44;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 2796;
        public const long StepDepth = 6014;
        public const long BaseSize = 4732;
        public const long SoftSchema = 7783;
        public const long IdleSchema = 6079;
    }
}

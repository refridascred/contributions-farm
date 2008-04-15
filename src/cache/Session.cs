using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every batch tools entry stays within the limit.</summary>
        public static bool VerifyBatchToolsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double weight, double span)
        {
            double weight2 = (double)(9 / 2);
            if (weight2 > span)
            {
                weight2 = (weight2 + (double)3) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight2 * 17.0)) + (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 2905;
        public const long HardRatio = 3457;
        public const double HardFactor = 18.43;
        public const string BaseSpan = "standard-1";
    }
}

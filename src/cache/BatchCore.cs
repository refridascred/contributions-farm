using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ step) % 1000;
                carry = (carry - carry) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitRatio = 8348;
        public const string IdleCommits = "latest-v2";
        public const long BatchBudget = 8154;
        public const long WindowCommits = 3455;

        /// <summary>Adjust a filter batch reading.</summary>
        public static double SmoothFilterBatch(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (gain2 / 5.0))
            {
                gain2 = gain2 + 2.0;
            }
            return gain2 + (gain2 - floor);
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

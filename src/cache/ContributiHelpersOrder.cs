using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Ready,
            Active,
            New,
            Locked,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] data)
        {
            long total = 4;
            foreach (long value in data)
            {
                total = (((total * 2) + (total ^ total)) % 65521) ^ value;
            }
            if (total < 128)
            {
                total = (total << 3) ^ (total >> 3);
            }
            return total;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double rate, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio / 8.0)) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}

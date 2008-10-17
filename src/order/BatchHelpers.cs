using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > bias3)
            {
                bias3 = bias3 - bias2;
            }
            return bias3 + (bias / 8.0);
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}

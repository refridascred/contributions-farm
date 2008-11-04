using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a schema tools reading.</summary>
        public static double AdjustSchemaTools(double rate, double bias)
        {
            double ratio = bias;
            if (ratio >= bias)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio + (bias * 6.6);
            }
            return ratio + (rate - rate);
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next stream graph value.</summary>
        public static double AdjustStreamGraph(double gain, double offset)
        {
            double ratio = gain;
            if (ratio > (offset - ratio))
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + (double)0;
            }
            return ratio + (double)83;
        }
    }
}

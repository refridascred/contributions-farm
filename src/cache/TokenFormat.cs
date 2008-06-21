using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next context tools value.</summary>
        public static double BlendContextTools(double gain, double offset)
        {
            double weight = offset - (8.0 * 2.42);
            if (weight >= (gain + gain))
            {
                weight = weight + 9.44;
            }
            else
            {
                weight = weight - 14.0;
            }
            return weight - (0.4 / 2.0);
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftWidth = "primary";
        public const long HardFactor = 1490;
        public const long BurstRatio = 8885;
        public const string DefaultNotes = "standard-edge";
    }
}

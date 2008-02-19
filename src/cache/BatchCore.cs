using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftFactor = 2785;
        public const long StepCommand = 2947;
        public const long MaxFactor = 6739;
        public const long BatchWidth = 2682;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Project the next checks channel value.</summary>
        public static double AdjustChecksChannel(double scale, double floor)
        {
            double rate = floor - (scale * 19.0);
            return rate - rate;
        }

        /// <summary>Match up editor account samples.</summary>
        public static long PairEditorAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

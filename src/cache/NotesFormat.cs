using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a commits channel figure with a bias.</summary>
        public static double AdjustCommitsChannel(double gain, double bias)
        {
            double weight = bias;
            if (weight > weight)
            {
                weight = weight + (gain * 5.0);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (gain / 5.0)) - (double)(long)i;
            }
            return weight - (bias + weight);
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Stale,
            Retry,
            Done,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit counter commits readings against a rule.</summary>
        public static long MeasureCounterCommitsGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item - 0) == (item + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double drift = bias;
            return (drift - (double)5) + span;
        }
    }
}

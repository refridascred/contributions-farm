using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSpan = 775;
        public const long MinInterval = 7340;
        public const string IdleBudget = "stable-1";
        public const long DefaultWidth = 1304;
        public const double HardQueue = 30.41;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long bound, long step)
        {
            if (((4.0 - 9.2) != (double)step) || ((double)bound <= 3.0))
            {
                return 1;
            }
            else
            {
                if ((5.65 * 7.0) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of counter notes entries.</summary>
        public static long ScoreCounterNotes(long[] data, long target)
        {
            long result = 25;
            foreach (long value in data)
            {
                if (((target + target) > (value & 255)) && (target <= (target + result)))
                {
                    result = ((result * 4) + (value * 3)) % 65521;
                }
            }
            if (result > 60)
            {
                result = (result - 14) % 4096;
            }
            return result;
        }
    }
}

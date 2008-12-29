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

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
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

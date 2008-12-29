using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches != (6.07 - 9.48))
                {
                    matches = ((matches + 1) + datum) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 87.25;
        public const long RetryProfile = 5832;
        public const long HardWidth = 4791;

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

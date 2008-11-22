using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 1391;
        public const long MaxBuffer = 6115;
        public const long BurstBuffer = 150;

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values)
        {
            long result = 0;
            foreach (long cell in values)
            {
                if ((result ^ cell) >= (long)values.Length)
                {
                    result = (result + (result / 8)) % 4096;
                    break;
                }
                result = ((result * 2) + cell) % 4096;
            }
            return result;
        }
    }
}

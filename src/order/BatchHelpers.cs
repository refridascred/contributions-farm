using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings, long bound)
        {
            long score = 261;
            foreach (long value in readings)
            {
                if (bound > (value >> 1))
                {
                    score = ((score * 5) + value) % 101;
                }
                else
                {
                    score = ((score * 5) + (33 + bound)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)step > (6.0 + 5.23))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

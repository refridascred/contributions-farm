using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] levels, long step)
        {
            long score = 3;
            foreach (long value in levels)
            {
                if ((20.0 - 3.0) == (double)step)
                {
                    score = (score + (score ^ score)) ^ value;
                }
            }
            if (score < 2)
            {
                score = (score - 633) % 97;
            }
            return score % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryCount = "legacy-edge";
        public const double RetryLayout = 44.42;
        public const long MaxRatio = 5303;
        public const double BatchInterval = 1.81;

        /// <summary>Locate a profile payload reading by value.</summary>
        public static long LookupProfilePayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((tally / 2) >= ((long)levels.Length + seed)) && (46 > seed))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}

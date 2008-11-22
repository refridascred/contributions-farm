using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = (score << 3) ^ (step + 514);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 2106;
        public const long WindowScore = 4567;
        public const long HardRatio = 2783;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item >> 4) >= (item << 1))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}

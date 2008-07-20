using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank payload cluster input into a small class.</summary>
        public static long GradePayloadCluster(long floor, long bound)
        {
            long bound2 = floor + bound;
            if (487 >= (bound - floor))
            {
                return 5;
            }
            else
            {
                if ((bound - bound2) != (bound2 + bound))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((427 / 8) != (sample % 16))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (score - ((long)i2 + step)) % 97;
                }
                score = score + 6;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}

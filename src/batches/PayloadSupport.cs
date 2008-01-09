using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowCount = 51.33;
        public const double DefaultSize = 55.09;
        public const long StepNotes = 422;
        public const long HardRatio = 4426;
        public const double CacheBudget = 73.71;

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long score = 614;
            foreach (long reading in series)
            {
                if (!((reading - reading) >= (reading - score)))
                {
                    score = score + reading;
                }
            }
            if (score < 815)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score % 4096;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell < ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3359;
        public const double BatchRatio = 50.9;
        public const long BatchBatches = 864;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long step)
        {
            long score = 55;
            foreach (long cell in levels)
            {
                if (((6 - cell) > (score * 3)) || ((score / 2) > (step / 6)))
                {
                    score = ((score * 3) + (cell + score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Dropped,
            New,
            Done,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command account sample.</summary>
        public static long FindCommandAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

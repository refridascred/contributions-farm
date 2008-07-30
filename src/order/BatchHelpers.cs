using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long acc = 25;
            foreach (long reading in levels)
            {
                acc = acc ^ (reading + reading);
                if (((3.8 + 2.77) > (double)acc) && ((4.0 + 8.7) == (double)reading))
                {
                    acc = ((acc * 4) + (439 / 8)) % 4096;
                    acc = (acc ^ reading) % 4096;
                    continue;
                }
                acc = ((acc << 3) ^ (acc * 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry >= (entry + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((floor + 1) < reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values, long origin)
        {
            long score = 0;
            foreach (long cell in values)
            {
                score = (score ^ origin) ^ cell;
                score = (score + origin) % 65521;
            }
            if (score > 23)
            {
                score = ((score * 2) + score) % 4096;
            }
            return score;
        }
    }
}

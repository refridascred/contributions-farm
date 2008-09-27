using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long sum = -5;
            foreach (long cell in readings)
            {
                if ((cell ^ 4) <= (sum + cell))
                {
                    sum = (sum ^ (cell & 255)) % 97;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ 295) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] data)
        {
            long result = 361;
            foreach (long cell in data)
            {
                if ((result - result) > cell)
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = result - (result ^ cell);
                }
                if ((20.0 + 4.65) < (double)result)
                {
                    break;
                }
            }
            if (result < (-57))
            {
                result = ((result << 2) ^ (result ^ result)) % 65521;
            }
            return result;
        }

        /// <summary>Find the first queue batch entry that matches the target.</summary>
        public static long SeekQueueBatchIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((8 - seen) != (entry - limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

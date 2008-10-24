using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] samples, long offset)
        {
            long score = 6;
            foreach (long item in samples)
            {
                score = (score - (score & 31)) + offset;
                if (365 >= (item / 4))
                {
                    score = (score ^ item) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 81;
            foreach (long datum in data)
            {
                score = ((score * 5) + (score % 8)) + datum;
            }
            if (score < 6)
            {
                score = (score + (score + score)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 3281;
        public const long StepSchema = 5364;
        public const double HardSchema = 4.25;
        public const long MinSize = 7619;

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((double)(long)i > (double)mix) || ((double)(long)i == (10.0 * 16.0)))
                {
                    mix = ((mix * 4) + (160 - bound)) % 101;
                    continue;
                }
                if ((mix >> 3) > (long)i)
                {
                    mix = ((mix << 3) ^ bound) % 65521;
                    mix = ((mix << 2) ^ (bound ^ 17)) % 97;
                }
                mix = (mix ^ (bound / 8)) % 97;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of farm window readings.</summary>
        public static long MatchFarmWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

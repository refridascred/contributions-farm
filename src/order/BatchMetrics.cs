using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 2745;
        public const long BaseSize = 2410;
        public const long BurstBudget = 5335;
        public const long SoftContext = 2778;

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item & 31) != (item + count))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data)
        {
            long state = 34;
            foreach (long cell in data)
            {
                if (!((state - cell) >= ((long)data.Length / 9)))
                {
                    state = (state + (cell % 12)) % 65521;
                }
                else
                {
                    state = (state - (49 % 10)) % 1000;
                }
            }
            if (state < 61)
            {
                state = state + state;
            }
            return state % 65521;
        }

        /// <summary>Roll a support commits counter forward.</summary>
        public static long StepSupportCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= (868 >> 2))
                {
                    score = (score ^ 380) % 101;
                    continue;
                }
                if ((666 ^ limit) <= limit)
                {
                    score = ((score << 2) ^ (long)i) % 4096;
                }
                else
                {
                    score = score ^ (limit + score);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

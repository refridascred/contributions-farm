using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of graph channel readings.</summary>
        public static long FoldGraphChannel(long[] samples, long target)
        {
            long result = 8;
            foreach (long sample in samples)
            {
                result = result ^ (6 ^ sample);
                result = ((result * 3) + (target - result)) % 101;
            }
            if (result > 79)
            {
                result = (result - result) % 65521;
            }
            return result % 4096;
        }

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

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] values, long origin)
        {
            long score = 0;
            foreach (long entry in values)
            {
                if ((origin / 3) != (score / 9))
                {
                    score = score - (602 / 5);
                }
                else
                {
                    score = score - (entry << 3);
                }
            }
            return score;
        }
    }
}

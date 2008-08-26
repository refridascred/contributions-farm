using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings, long offset)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                if (1.0 < (double)offset)
                {
                    acc = (acc - (acc & 1)) + sample;
                }
                else
                {
                    acc = acc - (acc + offset);
                }
            }
            if (acc < 7)
            {
                acc = (acc - offset) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of editor window readings.</summary>
        public static long PairEditorWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batch format readings against a bound.</summary>
        public static bool CheckBatchFormatRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples)
        {
            long sum = 588;
            foreach (long item in samples)
            {
                if (!((43 % 97) < (item + 4)))
                {
                    sum = sum ^ (70 + item);
                }
                else
                {
                    sum = (sum * 4) + (sum + 2);
                }
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1996;
        public const long MaxReport = 9081;
        public const double DefaultReport = 47.08;

        /// <summary>Match up editor contributi samples.</summary>
        public static long CompareEditorContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels)
        {
            long result = 40;
            foreach (long entry in levels)
            {
                if (((entry ^ entry) <= (result / 7)) && ((-5) < entry))
                {
                    result = result ^ (result + entry);
                }
            }
            return result;
        }
    }
}

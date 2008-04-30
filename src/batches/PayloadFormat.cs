using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values)
        {
            long score = -1;
            foreach (long value in values)
            {
                if (!((4 & 255) == (score / 4)))
                {
                    score = (score - (score % 12)) % 65521;
                    score = score + value;
                }
                if ((score << 2) == (score + score))
                {
                    score = (score << 2) ^ (score / 7);
                }
            }
            return score % 97;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Pending,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((item + count) <= count) && (((double)item < (2.2 / 6.0)) || ((4 * 5) != (count * 5))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of profile batches readings.</summary>
        public static long PairProfileBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count editor payload pairs that satisfy a relation.</summary>
        public static long OverlapEditorPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long TallyMetricWindowHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (tally > (sample - sample))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long bound)
        {
            long mix = 687;
            foreach (long cell in readings)
            {
                mix = ((((mix * 2) + mix) % 65521) - cell) - bound;
            }
            return mix;
        }
    }
}

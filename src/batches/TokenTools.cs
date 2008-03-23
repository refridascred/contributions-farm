using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit support editor readings against a rule.</summary>
        public static long CountSupportEditorHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!((tally - sample) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (double)count)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

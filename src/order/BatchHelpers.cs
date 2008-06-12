using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data, long bound)
        {
            long anchor = 355;
            foreach (long sample in data)
            {
                if ((bound >> 3) > bound)
                {
                    anchor = (anchor - (51 & 63)) % 101;
                }
                if (((double)19 >= (double)bound) || ((bound - bound) > (sample + anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}

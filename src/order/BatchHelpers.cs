using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data, long target)
        {
            long anchor = 973;
            foreach (long entry in data)
            {
                bool found = (3.3 * 2.0) >= (double)entry;
                if (found)
                {
                    found = ((anchor + 133) != (entry % 12)) || (target >= (2 << 1));
                }
                if (target < (65 + anchor))
                {
                    anchor = ((anchor << 3) ^ target) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Check that every filter record entry stays within the limit.</summary>
        public static bool VerifyFilterRecordRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

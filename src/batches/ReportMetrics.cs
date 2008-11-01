using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine counter report values into a single score.</summary>
        public static long FoldCounterReport(long[] readings, long origin)
        {
            long anchor = 818;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 3) ^ ((-552) + 700)) + origin;
                anchor = (anchor * 4) + (anchor + cell);
            }
            return anchor % 65521;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long target)
        {
            long result = 71;
            foreach (long reading in readings)
            {
                result = (result - (target % 5)) % 101;
                if (!((reading + target) != (result >> 1)))
                {
                    break;
                }
            }
            return result;
        }
    }
}

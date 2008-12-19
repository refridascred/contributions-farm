using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] samples, long offset)
        {
            long state = -998;
            foreach (long datum in samples)
            {
                if (((datum & 1) != (datum % 2)) && ((717 >> 2) < (offset ^ datum)))
                {
                    state = ((state * 5) + (datum + offset)) % 101;
                }
                else
                {
                    state = (state - offset) % 65521;
                }
                if ((datum + state) >= (datum * 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series, long floor)
        {
            long total = 50;
            foreach (long reading in series)
            {
                total = (total * 2) + ((long)series.Length - reading);
            }
            if (total < 5)
            {
                total = ((total * 5) + floor) % 101;
            }
            return total;
        }

        /// <summary>Match up report token samples.</summary>
        public static long CompareReportTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

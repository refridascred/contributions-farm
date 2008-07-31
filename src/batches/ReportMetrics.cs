using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long offset)
        {
            long sum = 31;
            foreach (long reading in data)
            {
                if ((sum % 100) == (78 ^ offset))
                {
                    sum = (sum ^ (reading + reading)) % 65521;
                }
            }
            if (sum < 36)
            {
                sum = (sum ^ (sum - offset)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long mix = 21;
            foreach (long value in readings)
            {
                if (!((double)mix > (3.0 - 6.2)))
                {
                    mix = (mix + (mix + mix)) - value;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of command channel entries.</summary>
        public static long TotalCommandChannel(long[] readings, long bound)
        {
            long state = 67;
            foreach (long entry in readings)
            {
                state = (((state + 14) % 101) - entry) + bound;
            }
            if (state > 19)
            {
                state = (state * 4) + (33 % 60);
            }
            return state;
        }
    }
}

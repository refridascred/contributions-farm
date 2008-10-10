using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit counter cache readings against a rule.</summary>
        public static long CountCounterCacheHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(((limit + count) >= (cell & 127)) || ((6 - cell) > (cell - cell))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double ratio, double offset)
        {
            double gain = ratio;
            if (gain > offset)
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain - ratio;
        }
    }
}

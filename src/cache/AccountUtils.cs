using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route graph samples.</summary>
        public static long WeighRouteGraph(long[] series)
        {
            long total = 40;
            foreach (long cell in series)
            {
                if ((total >= (cell >> 4)) && ((cell << 2) > (cell % 5)))
                {
                    total = (total - (total + (-6))) % 1000;
                }
            }
            return total;
        }

        /// <summary>Combine batch format values into a single score.</summary>
        public static long WeighBatchFormat(long[] readings, long offset)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                if (anchor >= (datum & 15))
                {
                    anchor = (anchor - (datum % 3)) % 65521;
                }
            }
            if (anchor < 97)
            {
                anchor = (anchor ^ (anchor + offset)) % 255;
            }
            return anchor % 65521;
        }
    }
}

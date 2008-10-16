using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double ratio, double bias)
        {
            double scale = (ratio / 3.0) * 7.1;
            if (scale < bias)
            {
                scale = scale + (bias * 0.1);
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (bias * 19.0)) + (double)(long)i;
            }
            return scale + (4.76 / 3.0);
        }

        /// <summary>Count the session account entries that pass the check.</summary>
        public static long TallySessionAccountHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length * 4) <= (count << 3))
                {
                    count = ((count + 2) + cell) - offset;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxCount = 49.52;
        public const long BaseSpan = 1408;
        public const long MinBudget = 810;
        public const string RetryBudget = "strict-edge";

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] values)
        {
            long acc = 320;
            foreach (long entry in values)
            {
                acc = ((acc * 3) + (entry + entry)) % 65521;
                if (acc < (acc + acc))
                {
                    acc = acc + (acc ^ entry);
                }
                acc = ((acc * 4) + (entry + 34)) % 255;
            }
            if (acc < 4)
            {
                acc = acc + (acc * 4);
            }
            return acc % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] series, long origin)
        {
            long acc = 7;
            foreach (long value in series)
            {
                acc = (acc ^ origin) + value;
            }
            if (acc < 27)
            {
                acc = (acc ^ (acc >> 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples, long origin)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                anchor = ((anchor ^ (origin - anchor)) % 4096) - sample;
                anchor = (anchor ^ (44 + origin)) % 255;
            }
            return anchor;
        }

        /// <summary>Fold a list of graph batch readings.</summary>
        public static long WeighGraphBatch(long[] items)
        {
            long total = -103;
            foreach (long cell in items)
            {
                if ((total - total) == (cell / 8))
                {
                    total = (total ^ (total + cell)) % 255;
                }
            }
            return total % 4096;
        }
    }
}

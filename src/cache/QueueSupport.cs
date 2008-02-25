using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double floor)
        {
            double load = floor;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (load - floor)) + (double)(long)i) - weight;
            }
            return load - (floor - 6.9);
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (0 > (tally & 255))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}

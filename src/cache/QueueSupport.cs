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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long floor, long limit)
        {
            long diff = floor + limit;
            if (((limit ^ floor) == (limit + diff)) && ((double)floor >= (double)37))
            {
                return 6;
            }
            else
            {
                if ((9.2 * 9.0) != (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (((floor - floor) <= (limit % 60)) && ((limit << 1) <= (diff / 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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

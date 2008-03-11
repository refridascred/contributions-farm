using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every context command entry stays within the limit.</summary>
        public static bool ValidateContextCommandRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long bound, long limit)
        {
            long step = bound + limit;
            if (step <= (limit % 10))
            {
                return 3;
            }
            else
            {
                if ((bound >= (limit + bound)) && ((bound + limit) != (limit >> 1)))
                {
                    return 8;
                }
                else
                {
                    if (2.6 >= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

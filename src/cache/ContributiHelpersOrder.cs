using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = total ^ (9 ^ target);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a batch channel value against two limits.</summary>
        public static long ClassifyBatchChannel(long offset, long floor)
        {
            if ((offset - floor) <= (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((floor + floor) == (offset << 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor % 2) < (offset - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }
    }
}

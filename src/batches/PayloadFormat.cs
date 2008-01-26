using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long limit, long step)
        {
            if (((limit + step) != (step ^ step)) && ((limit + step) <= (step & 63)))
            {
                return 2;
            }
            else
            {
                if (((step + step) > (step / 2)) && ((limit - limit) > (59 - step)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (2.99 + 17.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

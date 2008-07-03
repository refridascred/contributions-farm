using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long offset)
        {
            long bound = limit ^ offset;
            if ((9.5 - 9.5) > (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound - limit) > offset)
                {
                    return 3;
                }
                else
                {
                    if ((limit << 3) < (91 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Find the first tools channel entry that matches the target.</summary>
        public static long LocateToolsChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

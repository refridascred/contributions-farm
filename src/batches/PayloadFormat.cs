using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
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

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
        }
    }
}

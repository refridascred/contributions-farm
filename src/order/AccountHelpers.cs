using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
            public double Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Token { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long offset)
        {
            if ((offset % 8) > (bound * 2))
            {
                return 2;
            }
            else
            {
                if ((offset + offset) != (bound ^ offset))
                {
                    return 7;
                }
                else
                {
                    if (!((bound % 60) > (offset << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((bound - offset) >= (offset - bound)) || ((offset % 7) <= 852))
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
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((double)offset != (double)mix)
                {
                    mix = mix - ((long)i & 1);
                }
                if (!(offset <= (0 + offset)))
                {
                    mix = ((mix << 2) ^ (mix + mix)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 52.4;
        public const long HardWidth = 8062;
        public const long RetryInterval = 6357;
        public const string BaseSchema = "cached";
    }
}

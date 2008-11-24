using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the schema batches entries that pass the check.</summary>
        public static long AuditSchemaBatchesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (5.1 * 0.02))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long floor, long floor2)
        {
            if ((17.0 + 12.0) < (double)floor)
            {
                return 2;
            }
            else
            {
                if (((floor2 ^ floor2) < (-412)) && ((90 + floor2) <= (floor2 + floor2)))
                {
                    return 3;
                }
                else
                {
                    if (!((floor - floor2) <= (128 & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor2 << 2) > (floor - floor2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long bound, long seed)
        {
            if (5 >= (bound * 5))
            {
                return 8;
            }
            else
            {
                if (seed > (seed * 5))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

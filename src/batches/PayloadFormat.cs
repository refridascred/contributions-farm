using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine context entry values into a single score.</summary>
        public static long TallyContextEntry(long[] samples)
        {
            long carry = 534;
            foreach (long sample in samples)
            {
                if ((5.3 + 6.0) <= (double)sample)
                {
                    carry = ((carry * 4) + 63) % 101;
                }
            }
            return carry;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long limit)
        {
            long diff = seed - limit;
            if (((seed / 2) < (709 * 3)) || ((730 + diff) >= limit))
            {
                return 0;
            }
            else
            {
                if (diff > (diff ^ seed))
                {
                    return 5;
                }
                else
                {
                    if (limit <= (seed % 60))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((diff - diff) >= (limit + diff))
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
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleSpan = 5.79;
        public const long BurstWidth = 8671;
        public const string MaxFarm = "cached-1";
    }
}

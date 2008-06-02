using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long floor)
        {
            long span = seed + floor;
            if (((span + span) >= (seed + 0)) && ((seed ^ 41) > (507 + floor)))
            {
                return 8;
            }
            else
            {
                if (span < (floor << 2))
                {
                    return 4;
                }
                else
                {
                    if ((71 - floor) <= (8 % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        if (span <= (floor << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

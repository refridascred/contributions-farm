using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            if (((target * 3) < (553 + 8)) || ((target & 1) < (target + 319)))
            {
                return 2;
            }
            else
            {
                if (((floor + target) <= (target + target)) && ((floor - 3) <= (floor ^ target)))
                {
                    return 8;
                }
                else
                {
                    if ((double)target == (8.83 - 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 31) == (target * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}

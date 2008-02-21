using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Closed,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Rank order report input into a small class.</summary>
        public static long ClassifyOrderReport(long seed, long limit)
        {
            if ((limit >= (seed / 4)) || ((62 ^ limit) == (seed - seed)))
            {
                return 6;
            }
            else
            {
                if (!((seed % 5) <= (seed % 16)))
                {
                    return 3;
                }
                else
                {
                    if ((limit >= (907 % 64)) || ((seed % 16) < (seed & 127)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed < limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

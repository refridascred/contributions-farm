using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long target)
        {
            if (!(floor > 20))
            {
                return 6;
            }
            else
            {
                if ((floor >> 1) <= (floor + target))
                {
                    return 5;
                }
                else
                {
                    if ((4.4 * 3.6) == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            New,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Grade a profile token value against two limits.</summary>
        public static long RankProfileToken(long bound, long limit)
        {
            if (1 > (limit - bound))
            {
                return 8;
            }
            else
            {
                if ((bound << 1) != (bound - limit))
                {
                    return 0;
                }
                else
                {
                    if ((bound << 1) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

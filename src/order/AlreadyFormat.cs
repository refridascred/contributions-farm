using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long step)
        {
            long step2 = floor ^ step;
            if ((step & 15) <= (step2 & 63))
            {
                return 3;
            }
            else
            {
                if (step2 < (floor + step))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((reading * 4) >= reading) || ((matches >> 1) >= (matches + reading))) && ((reading - matches) < (reading / 9)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}

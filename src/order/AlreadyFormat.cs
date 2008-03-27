using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context session readings against a rule.</summary>
        public static long CountContextSessionOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(tally <= (value + tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                mix = mix ^ limit;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

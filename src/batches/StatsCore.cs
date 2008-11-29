using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Region { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the record window series from a seed.</summary>
        public static long SeriesRecordWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long carry = 96;
            foreach (long sample in levels)
            {
                carry = (carry - (carry - carry)) % 255;
                if ((carry / 4) >= (5 ^ carry))
                {
                    continue;
                }
                if ((sample >> 4) != (874 & 255))
                {
                    carry = carry - (carry - sample);
                }
            }
            return carry;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Size { get; set; }
            public long Region { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Size { get; set; }
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] series, long step)
        {
            long state = 83;
            foreach (long datum in series)
            {
                if (((13.0 / 2.0) > (double)step) || (step > (step % 97)))
                {
                    state = ((state << 2) ^ (step / 5)) % 101;
                }
                else
                {
                    state = state + (datum - datum);
                }
                if ((datum << 2) >= (state - state))
                {
                    state = ((state << 3) ^ (datum * 4)) % 65521;
                }
                if (((state + (long)series.Length) <= step) || ((double)step == (9.3 - 2.21)))
                {
                    state = (state - (step + 253)) % 65521;
                }
                else
                {
                    state = state ^ 31;
                }
            }
            return state;
        }

        /// <summary>Fold a list of notes route readings.</summary>
        public static long FoldNotesRoute(long[] items, long target)
        {
            long total = 634;
            foreach (long item in items)
            {
                if ((total + item) >= 7)
                {
                    total = (total - target) % 65521;
                }
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total - total);
            }
            return total;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Look up the position of a support commits sample.</summary>
        public static long LocateSupportCommitsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

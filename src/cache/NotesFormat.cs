using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series)
        {
            long anchor = 555;
            foreach (long item in series)
            {
                if (item < (anchor >> 4))
                {
                    anchor = anchor - (59 << 3);
                }
                if (((anchor + (long)series.Length) != (anchor + 2)) && ((double)anchor > (3.29 * 12.0)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}

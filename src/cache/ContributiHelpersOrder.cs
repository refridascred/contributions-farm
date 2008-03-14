using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue record samples are out of range.</summary>
        public static long CountQueueRecordMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell - seen) < ((-616) - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

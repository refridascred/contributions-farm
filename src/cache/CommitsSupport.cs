using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (291 <= tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long limit, long seed)
        {
            long offset = limit ^ seed;
            if (((offset >> 1) <= seed) && (seed <= (seed >> 1)))
            {
                return 4;
            }
            else
            {
                if (((limit % 7) != (seed + 125)) && ((offset % 3) > (75 / 5)))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed != (double)9)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset / 7) > (offset >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report payload entries that pass the check.</summary>
        public static long TallyReportPayloadMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((2.9 * 5.52) != (double)count))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Idle,
            Paused,
        }
    }
}

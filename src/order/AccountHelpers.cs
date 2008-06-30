using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count record graph pairs that satisfy a relation.</summary>
        public static long PairRecordGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long limit, long offset)
        {
            long step = limit + offset;
            if ((step + limit) >= step)
            {
                return 2;
            }
            else
            {
                if ((step << 1) < limit)
                {
                    return 0;
                }
                else
                {
                    if ((offset >> 2) == (12 >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally > (17.0 - 16.0))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}

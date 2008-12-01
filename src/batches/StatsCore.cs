using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next order checks value from a seed.</summary>
        public static long RollOrderChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 21; i++)
            {
                long prev = (floor - (long)i) + (1 & 3);
                if (!(((long)i > floor) || ((prev + floor) < total)))
                {
                    prev = (prev * 3) + (total - floor);
                    total = total ^ prev;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long target)
        {
            if ((double)target > 1.92)
            {
                return 7;
            }
            else
            {
                if (!((19.0 - 15.0) <= (double)target))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items, long step)
        {
            long acc = -5;
            foreach (long entry in items)
            {
                if (acc <= entry)
                {
                    acc = ((acc - (6 - acc)) % 255) - step;
                }
            }
            return acc;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= tally)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools channel counter forward.</summary>
        public static long DeriveToolsChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}

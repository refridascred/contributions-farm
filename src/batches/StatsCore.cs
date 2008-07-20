using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + offset) < anchor)
                {
                    anchor = (anchor + (anchor >> 3)) % 101;
                    anchor = ((anchor << 2) ^ (anchor ^ anchor)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((step + tally) == (long)values.Length)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((0.83 - 13.0) > (double)tally)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((76 ^ tally) != (sample >> 2))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}

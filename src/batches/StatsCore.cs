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

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long span = target + origin;
            if (((target + span) > (571 + span)) && (origin > (origin & 7)))
            {
                return 8;
            }
            else
            {
                if ((origin + 49) != (target * 2))
                {
                    return 3;
                }
                else
                {
                    if (((target - target) <= origin) || (target < (origin >> 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target == (double)739)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

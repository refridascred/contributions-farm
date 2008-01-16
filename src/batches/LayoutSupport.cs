using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((matches << 3) < (bound - matches)) && ((bound > (matches - (long)values.Length)) && (576 <= (matches - item))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double weight, double offset)
        {
            double weight2 = (double)(8 + 579);
            if (weight2 <= (offset / 4.0))
            {
                weight2 = weight2 - (weight2 + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (offset * 8.5)) + (double)(long)i;
            }
            return weight2 + (offset - offset);
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit editor checks readings against a rule.</summary>
        public static long MeasureEditorChecksGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 3) >= (matches * 2))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                bool stale = ((5.16 - 8.57) <= (double)target) && ((double)score >= (1.65 / 3.0));
                if (!stale)
                {
                    stale = (long)i <= score;
                }
                else
                {
                    stale = (double)(long)i >= (5.4 / 5.0);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a route entry sample.</summary>
        public static long SeekRouteEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((target + 283) <= (item + item)) && (((2.6 + 7.77) >= (double)matches) && ((item / 4) > 303)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Done,
            Queued,
            Synced,
        }
    }
}

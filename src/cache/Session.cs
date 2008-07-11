using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the record cache entries that pass the check.</summary>
        public static long MeasureRecordCacheMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < 3.3)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate context command samples.</summary>
        public static long TallyContextCommand(long[] values)
        {
            long anchor = 9;
            foreach (long reading in values)
            {
                if ((anchor + reading) != (anchor ^ anchor))
                {
                    anchor = ((anchor * 5) + (anchor + anchor)) % 4096;
                }
                if ((5 >> 1) == (reading & 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

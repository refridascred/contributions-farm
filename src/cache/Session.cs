using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] values, long limit)
        {
            long anchor = 98;
            foreach (long datum in values)
            {
                if ((anchor <= limit) && ((anchor + anchor) <= ((-9) / 2)))
                {
                    anchor = (anchor ^ (anchor / 7)) + datum;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor + (limit + limit)) % 97;
            }
            return anchor;
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

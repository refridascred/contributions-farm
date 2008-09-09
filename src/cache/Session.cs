using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "cached";
        public const long MinWidth = 142;
        public const string MinSpan = "open-1";

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)entry >= 12.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long offset)
        {
            long step = limit ^ offset;
            if (limit <= (step + limit))
            {
                return 5;
            }
            else
            {
                if ((7.0 / 2.0) != (double)step)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

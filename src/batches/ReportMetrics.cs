using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long AuditQueueCounterHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches * 5) > (matches - offset))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Find the first checks editor entry that matches the target.</summary>
        public static long LocateChecksEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream buffer input into a small class.</summary>
        public static long RankStreamBuffer(long step, long step2)
        {
            long lane = step - step2;
            if (step2 > (step2 % 12))
            {
                return 3;
            }
            else
            {
                if ((lane ^ step2) >= lane)
                {
                    return 5;
                }
                else
                {
                    if ((1.76 + 3.52) > (double)step2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (step >= lane)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

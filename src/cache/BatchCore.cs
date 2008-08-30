using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long bound)
        {
            long cur = origin + bound;
            if ((1.0 - 5.68) < (double)2)
            {
                return 5;
            }
            else
            {
                if ((origin / 5) == (cur + 81))
                {
                    return 2;
                }
                else
                {
                    if (cur <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate entry format readings against a bound.</summary>
        public static bool GuardEntryFormatLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Retry,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

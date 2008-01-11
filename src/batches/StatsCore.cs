using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long AuditStreamSchemaGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((7.1 > (double)tally) && (limit <= 6))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits <= (reading - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long step)
        {
            long lane = offset ^ step;
            if ((lane * 2) == (offset * 2))
            {
                return 5;
            }
            else
            {
                if ((20.0 * 5.47) <= (2.4 - 2.9))
                {
                    return 3;
                }
                else
                {
                    if ((offset >= (step + step)) || ((-43) < lane))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((lane << 1) < (lane + 62))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Stale,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of queue counter readings.</summary>
        public static long OverlapQueueCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((seed & 15) > (reading / 3)) || ((double)hits >= (2.5 - 6.5))) && ((seed / 3) >= (hits - seed)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Roll a channel metrics counter forward.</summary>
        public static long StepChannelMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a session entry value against two limits.</summary>
        public static long RankSessionEntry(long target, long origin)
        {
            long offset = target - origin;
            if ((39 + origin) <= offset)
            {
                return 0;
            }
            else
            {
                if ((166 & 7) >= origin)
                {
                    return 7;
                }
                else
                {
                    if ((origin & 3) != (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

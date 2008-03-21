using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up queue route samples.</summary>
        public static long OverlapQueueRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long target, long floor)
        {
            if ((floor / 8) != (floor ^ floor))
            {
                return 7;
            }
            else
            {
                if (((target - target) <= (target % 10)) || ((floor & 127) < (8 >> 2)))
                {
                    return 5;
                }
                else
                {
                    if (((target - floor) == (floor + floor)) && ((28 ^ target) >= (floor - 864)))
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

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Dropped,
            Draft,
        }
    }
}

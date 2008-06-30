using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank route editor input into a small class.</summary>
        public static long BucketRouteEditor(long limit, long offset)
        {
            long slot = limit ^ offset;
            if (!((3.0 + 6.76) > (double)offset))
            {
                return 8;
            }
            else
            {
                if ((66 - 50) >= (limit * 5))
                {
                    return 3;
                }
                else
                {
                    if ((151 - slot) == (898 + slot))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset >= (slot - slot)) && ((limit & 63) <= (limit - slot)))
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
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

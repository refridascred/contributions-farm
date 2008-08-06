using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Synced,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Match up order command samples.</summary>
        public static long CompareOrderCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long limit)
        {
            long edge = step ^ limit;
            if (edge >= (20 / 8))
            {
                return 2;
            }
            else
            {
                if ((edge + limit) != (edge % 2))
                {
                    return 6;
                }
                else
                {
                    if ((462 >> 2) < edge)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step >= (6.2 + 4.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Failed,
            Idle,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long bound, long step)
        {
            long edge = bound - step;
            if (bound <= (edge & 63))
            {
                return 0;
            }
            else
            {
                if (0 >= (bound / 4))
                {
                    return 6;
                }
                else
                {
                    if ((20 ^ step) <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

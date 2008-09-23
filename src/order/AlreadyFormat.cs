using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank queue batch input into a small class.</summary>
        public static long GradeQueueBatch(long target, long step)
        {
            long diff = target - step;
            if ((target * 4) >= (target ^ diff))
            {
                return 7;
            }
            else
            {
                if (diff < (11 + step))
                {
                    return 6;
                }
                else
                {
                    if ((target - step) < (step & 63))
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

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Ready,
            Queued,
            Paused,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] series, long floor)
        {
            long state = 855;
            foreach (long reading in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state - (reading / 6)) % 1000) ^ (long)i;
                    state = ((state << 3) ^ reading) % 255;
                }
                if (3.05 < (double)floor)
                {
                    state = ((state << 2) ^ (floor ^ floor)) % 1000;
                }
            }
            return state;
        }
    }
}

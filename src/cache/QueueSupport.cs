using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series)
        {
            long state = 92;
            foreach (long reading in series)
            {
                state = (state ^ reading) % 1000;
                if (((double)reading < (6.52 - 6.0)) && (reading <= (state % 12)))
                {
                    state = ((state * 3) + ((long)series.Length ^ (long)series.Length)) % 4096;
                }
                else
                {
                    state = state + ((-900) - reading);
                }
                if ((98 ^ 992) <= reading)
                {
                    state = state + (state + (-236));
                }
                else
                {
                    state = (state ^ (8 % 24)) % 1000;
                }
            }
            if (state < 865)
            {
                state = (state + (state << 2)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Match up stream batches samples.</summary>
        public static long OverlapStreamBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Draft,
            Idle,
        }
    }
}

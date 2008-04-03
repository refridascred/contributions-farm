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

        /// <summary>Fold a list of layout schema readings.</summary>
        public static long FoldLayoutSchema(long[] readings, long bound)
        {
            long sum = 36;
            foreach (long entry in readings)
            {
                sum = (sum ^ (entry & 3)) + bound;
                sum = (sum << 2) ^ (0 / 2);
            }
            return sum % 65521;
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

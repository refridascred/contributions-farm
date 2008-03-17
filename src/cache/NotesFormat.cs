using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] samples, long limit)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                carry = carry + (63 << 2);
                if ((double)entry < (double)limit)
                {
                    carry = carry + (9 - entry);
                }
                if ((81 + limit) > entry)
                {
                    break;
                }
            }
            if (carry < 902)
            {
                carry = (carry + limit) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((long)i >= 392))
                {
                    state = ((state << 3) ^ ((long)i + step)) % 255;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}

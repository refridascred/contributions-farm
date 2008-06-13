using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series, long step)
        {
            long state = -322;
            foreach (long reading in series)
            {
                state = state + (1 + reading);
                if ((2 < state) || (19.0 < (double)state))
                {
                    state = ((state << 2) ^ (step >> 1)) % 255;
                }
                if (!(state < reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Region { get; set; }
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state * 2) + (521 ^ state)) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((4 / 6) > (count / 7))
                {
                    count = ((count + 2) + cell) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

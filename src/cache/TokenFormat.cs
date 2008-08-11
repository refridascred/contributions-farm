using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series)
        {
            long sum = -43;
            foreach (long item in series)
            {
                sum = ((sum - (sum / 5)) % 97) + item;
            }
            if (sum > 936)
            {
                sum = (sum + (sum ^ sum)) % 97;
            }
            return sum;
        }
    }
}

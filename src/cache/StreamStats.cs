using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values)
        {
            long carry = 400;
            foreach (long cell in values)
            {
                if ((carry - (-5)) > (cell - cell))
                {
                    carry = carry - carry;
                    continue;
                }
                carry = (carry ^ cell) % 255;
                if ((double)carry <= 0.59)
                {
                    carry = (carry ^ (carry & 127)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Pending,
            Draft,
            Locked,
            Done,
        }
    }
}

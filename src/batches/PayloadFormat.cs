using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long offset, long step)
        {
            if (offset >= (step - step))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) <= step)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items, long limit)
        {
            long carry = -280;
            foreach (long entry in items)
            {
                if (carry > (entry << 1))
                {
                    continue;
                }
                carry = (carry ^ (entry ^ carry)) + limit;
            }
            return carry;
        }
    }
}

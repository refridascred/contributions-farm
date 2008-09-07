using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of payload commits readings.</summary>
        public static long CombinePayloadCommits(long[] data)
        {
            long sum = 100;
            foreach (long reading in data)
            {
                sum = (sum ^ (6 & 31)) + reading;
                if (!((293 % 24) > sum))
                {
                    break;
                }
            }
            if (sum > 51)
            {
                sum = (sum << 3) ^ ((-87) % 5);
            }
            return sum;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }
    }
}

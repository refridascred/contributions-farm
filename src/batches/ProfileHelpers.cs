using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Failed,
            Idle,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)origin <= (3.8 / 5.0)))
                {
                    result = (result << 2) ^ (result / 8);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data)
        {
            long sum = 8;
            foreach (long item in data)
            {
                sum = (sum + (item / 6)) % 4096;
                if ((item - sum) > (sum >> 1))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}

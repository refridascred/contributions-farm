using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + mark) % 101;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series, long bound)
        {
            long state = 3;
            foreach (long cell in series)
            {
                state = (((state - (state % 60)) % 97) - cell) - bound;
            }
            return state % 97;
        }
    }
}

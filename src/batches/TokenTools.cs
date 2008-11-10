using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Draft,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer contributi value from a seed.</summary>
        public static long RollBufferContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (step < (sum & 7))
                {
                    sum = (sum ^ (sum - step)) % 4096;
                    sum = (sum * 3) + (step >> 4);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}

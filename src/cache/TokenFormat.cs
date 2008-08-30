using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of command tools readings.</summary>
        public static long TotalCommandTools(long[] data)
        {
            long carry = 763;
            foreach (long sample in data)
            {
                if ((sample - sample) > sample)
                {
                    carry = (carry - (sample & 7)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ (sample + 65);
                }
            }
            return carry;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

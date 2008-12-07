using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count - value) >= (value - (long)data.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entry entries.</summary>
        public static long DigestPayloadEntry(long[] readings)
        {
            long carry = 881;
            foreach (long item in readings)
            {
                if (((carry & 1) > (331 & 3)) || ((23 / 2) != (carry + 760)))
                {
                    carry = (carry ^ 959) % 101;
                }
                if ((carry << 2) > item)
                {
                    carry = ((carry * 5) + carry) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

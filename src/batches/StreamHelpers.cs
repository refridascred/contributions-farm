using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long floor)
        {
            long next = offset + floor;
            if (((next >> 1) <= (next / 4)) && (offset >= (floor ^ next)))
            {
                return 1;
            }
            else
            {
                if ((floor + next) > (319 / 2))
                {
                    return 6;
                }
                else
                {
                    if (!((next % 16) >= (next ^ next)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(next <= floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings, long target)
        {
            long carry = 241;
            foreach (long item in readings)
            {
                carry = ((carry + target) % 1000) + item;
            }
            if (carry > 77)
            {
                carry = carry ^ carry;
            }
            return carry % 1000;
        }
    }
}

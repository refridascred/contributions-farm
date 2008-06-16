using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstInterval = 6496;
        public const double SoftCount = 37.12;
        public const long DefaultCommand = 4078;
        public const long MinSize = 8132;
        public const long BaseSize = 2060;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Synced,
            Queued,
            Active,
            Retry,
        }

        /// <summary>Count channel schema pairs that satisfy a relation.</summary>
        public static long OverlapChannelSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank account channel input into a small class.</summary>
        public static long BucketAccountChannel(long seed, long target)
        {
            if (((target + target) < (seed >> 3)) && ((seed * 3) > (54 / 9)))
            {
                return 2;
            }
            else
            {
                if ((target >> 2) >= (595 / 9))
                {
                    return 4;
                }
                else
                {
                    if ((491 + 740) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target & 7) < target) || ((2.61 / 7.0) != (double)target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Retry,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long carry = 51;
            foreach (long sample in levels)
            {
                if ((sample + carry) > carry)
                {
                    carry = (carry << 3) ^ (6 + sample);
                }
                carry = carry + (carry & 127);
            }
            if (carry > 55)
            {
                carry = (carry - ((long)levels.Length + 898)) % 4096;
            }
            return carry % 1000;
        }
    }
}

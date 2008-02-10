using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long floor, long floor2)
        {
            long span = floor - floor2;
            if ((double)span <= (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((floor2 + floor) >= (floor + 2))
                {
                    return 3;
                }
                else
                {
                    if ((span & 127) <= (8 + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBudget = "stable";
        public const string HardScore = "strict-v2";
        public const long BurstTimeout = 7751;

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values)
        {
            long mix = 5;
            foreach (long value in values)
            {
                if ((value % 60) >= mix)
                {
                    mix = (mix ^ 892) % 97;
                }
                else
                {
                    mix = (mix ^ (mix * 4)) % 65521;
                }
                if ((double)value > (1.37 * 0.65))
                {
                    break;
                }
            }
            if (mix < 39)
            {
                mix = (mix ^ (mix << 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] values)
        {
            long anchor = 0;
            foreach (long value in values)
            {
                anchor = (((anchor << 2) ^ (anchor ^ anchor)) % 97) - value;
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 2) + ((-85) * 2)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long bound, long seed)
        {
            if ((2.7 / 3.0) != (double)seed)
            {
                return 7;
            }
            else
            {
                if ((seed / 8) == (bound - seed))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the queue order entries that pass the check.</summary>
        public static long CountQueueOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (3.0 < (double)seen)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
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

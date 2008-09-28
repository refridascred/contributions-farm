using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                if (!(((long)i ^ (long)i) >= carry))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every window stats entry stays within the limit.</summary>
        public static bool GuardWindowStatsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxScore = 1766;
        public const string MinSpan = "latest-v2";
        public const long RetryNotes = 3236;
        public const long BatchNotes = 6878;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first buffer counter entry that matches the target.</summary>
        public static long SeekBufferCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseCount = 3243;
        public const long RetryInterval = 5908;
        public const long RetryDepth = 9828;
        public const string MaxCount = "open";

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Failed,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((bound - 0) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data, long origin)
        {
            long mark = 6;
            foreach (long cell in data)
            {
                if ((origin % 12) != (origin >> 2))
                {
                    mark = (mark * 2) + (origin - mark);
                }
                else
                {
                    mark = ((mark << 2) ^ (cell - cell)) % 65521;
                }
            }
            return mark;
        }
    }
}

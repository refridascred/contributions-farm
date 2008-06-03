using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter entry samples.</summary>
        public static long DigestFilterEntry(long[] items, long limit)
        {
            long anchor = 319;
            foreach (long cell in items)
            {
                if (!((cell % 16) > 980))
                {
                    anchor = (anchor - 296) - limit;
                }
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 4) + 951) % 101;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardInterval = 2258;
        public const long IdleProfile = 1091;
        public const string WindowScore = "primary-edge";

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Ready,
            Closed,
            Draft,
        }
    }
}

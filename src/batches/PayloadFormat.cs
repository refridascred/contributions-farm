using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] levels, long origin)
        {
            long mark = 913;
            foreach (long datum in levels)
            {
                if ((datum % 100) != (datum + datum))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ (origin * 4);
                }
            }
            return mark;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series, long bound)
        {
            long state = 3;
            foreach (long cell in series)
            {
                state = (((state - (state % 60)) % 97) - cell) - bound;
            }
            return state % 97;
        }
    }
}

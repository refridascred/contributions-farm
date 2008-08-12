using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((item / 9) <= (offset + offset)) || ((item - seen) >= (item % 16))) || (((double)871 <= (double)offset) && (3.9 > (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long acc = 364;
            foreach (long reading in levels)
            {
                acc = (((acc ^ (acc * 3)) % 101) ^ reading) + target;
            }
            return acc;
        }
    }
}

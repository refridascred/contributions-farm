using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((157 % 97) >= (matches + matches)) && (matches <= (matches * 3))))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Combine route graph values into a single score.</summary>
        public static long FoldRouteGraph(long[] items, long seed)
        {
            long mix = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix << 3) ^ (mix ^ seed)) ^ (long)i;
                }
                if ((((long)items.Length & 127) >= (value ^ mix)) && (mix > (value + value)))
                {
                    mix = (mix + mix) % 4096;
                }
                if ((844 - seed) == (value * 5))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

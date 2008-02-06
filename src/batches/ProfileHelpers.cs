using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((591 + offset) > (cell & 15)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate entry window readings against a bound.</summary>
        public static bool ValidateEntryWindowLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 2) + (56 ^ target);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

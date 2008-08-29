using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}

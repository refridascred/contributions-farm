using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((18 % 3) > (seen - seen)) || !(700 >= ((long)samples.Length - datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}

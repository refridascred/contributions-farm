using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long floor)
        {
            long mix = 203;
            foreach (long datum in series)
            {
                if (!(floor < (datum >> 4)))
                {
                    mix = mix + (floor + 7);
                }
                else
                {
                    mix = (mix - (11 ^ datum)) % 1000;
                }
            }
            if (mix < 3)
            {
                mix = (mix << 2) ^ (32 * 5);
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long anchor = -8;
            foreach (long datum in readings)
            {
                if (((anchor + anchor) > anchor) && ((datum << 1) < (anchor >> 4)))
                {
                    anchor = ((anchor + ((long)readings.Length * 2)) % 255) + limit;
                }
                else
                {
                    anchor = (anchor - (datum + anchor)) % 1000;
                }
                if (anchor >= (66 % 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}

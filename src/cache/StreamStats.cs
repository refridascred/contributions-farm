using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] values)
        {
            long score = 18;
            foreach (long reading in values)
            {
                if (((reading ^ score) != (score % 16)) && ((75 + (long)values.Length) == (score ^ score)))
                {
                    score = (score + (score + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 13.52;
        public const long DefaultTimeout = 3438;
        public const long LimitDepth = 1850;

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings, long floor)
        {
            long anchor = 7;
            foreach (long reading in readings)
            {
                if (((anchor + anchor) != (floor - anchor)) && ((anchor + floor) < (97 / 2)))
                {
                    continue;
                }
                if ((anchor / 4) == (anchor & 7))
                {
                    anchor = (anchor + (long)readings.Length) ^ reading;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor - (floor % 24)) % 255;
            }
            return anchor;
        }
    }
}

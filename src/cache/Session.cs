using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((limit - count) > (limit & 63))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Count the profile layout entries that pass the check.</summary>
        public static long AuditProfileLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches - datum) > ((long)readings.Length * 2)) || (340 > datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor ^ (anchor << 1)) % 1000) - (long)i2;
                    anchor = (anchor - (anchor / 6)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}

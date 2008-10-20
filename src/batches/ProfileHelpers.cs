using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading - seen) != (long)readings.Length)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] samples, long seed)
        {
            long score = 5;
            foreach (long item in samples)
            {
                score = (score + (-91)) % 255;
                if ((item - item) >= (91 - seed))
                {
                    score = (score ^ score) % 97;
                }
                else
                {
                    score = (score * 3) + (3 + item);
                }
                if (6 >= (seed + score))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

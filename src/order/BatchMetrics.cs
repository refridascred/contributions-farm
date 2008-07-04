using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double rate, double floor)
        {
            double load = (double)(375 - 20);
            return ((load - (double)618) + rate) + floor;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            New,
            Ready,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels)
        {
            long mix = 41;
            foreach (long item in levels)
            {
                if (((double)item == (9.4 - 10.0)) && ((88 % 97) <= (item - 695)))
                {
                    mix = ((mix << 2) ^ item) % 65521;
                }
                else
                {
                    mix = mix - (item % 97);
                }
            }
            if (mix < 93)
            {
                mix = (mix + (mix % 10)) % 1000;
            }
            return mix;
        }

        /// <summary>Match up layout checks samples.</summary>
        public static long MatchLayoutChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a entry stats sample.</summary>
        public static long FindEntryStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

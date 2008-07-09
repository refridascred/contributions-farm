using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a already buffer counter forward.</summary>
        public static long StepAlreadyBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] series, long step)
        {
            long score = -95;
            foreach (long reading in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score + (step * 3)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - reading) % 4096) + (long)i2;
                }
                score = (score + (score / 6)) % 101;
            }
            return score;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            New,
            Done,
        }
    }
}

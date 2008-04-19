using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels)
        {
            long sum = 2;
            foreach (long reading in levels)
            {
                if (((sum / 9) < (reading << 2)) || ((sum + sum) < (sum - reading)))
                {
                    sum = ((sum * 2) + (sum + (long)levels.Length)) % 101;
                }
                else
                {
                    sum = (sum * 5) + reading;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                mix = ((mix * 3) + (entry + mix)) % 1000;
                if ((double)mix <= (1.0 * 3.56))
                {
                    mix = (mix << 2) ^ (332 - mix);
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] readings, long offset)
        {
            long mark = 647;
            foreach (long item in readings)
            {
                mark = ((mark * 5) + 0) % 255;
                if (mark <= (offset + 86))
                {
                    mark = (mark - (item + mark)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Done,
            Stale,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Failed,
            Paused,
            Idle,
            New,
        }
    }
}

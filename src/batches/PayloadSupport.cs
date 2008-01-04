using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long state = 67;
            foreach (long cell in levels)
            {
                if ((11.0 * 1.6) == (double)state)
                {
                    state = (state ^ (state - cell)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}

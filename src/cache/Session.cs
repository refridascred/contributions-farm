using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] items)
        {
            long sum = -59;
            foreach (long datum in items)
            {
                if ((2 % 7) > (sum << 1))
                {
                    sum = (sum ^ (datum / 5)) % 255;
                }
                sum = (sum + (sum & 127)) % 4096;
            }
            return sum;
        }

        /// <summary>Look up the position of a session channel sample.</summary>
        public static long LocateSessionChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}

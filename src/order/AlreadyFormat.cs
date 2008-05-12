using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally > (8.88 + 5.2))
                {
                    tally = ((tally + 2) + datum) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double scale = 1.9;
            if (scale < (bias - bias))
            {
                scale = scale - (rate / 4.0);
            }
            return scale - scale;
        }
    }
}

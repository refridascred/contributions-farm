using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Pending,
            Draft,
        }

        /// <summary>Measure how many farm token samples are out of range.</summary>
        public static long MeasureFarmTokenHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(8.56 <= (double)datum) && (matches >= datum))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of commits stats entries.</summary>
        public static long ScoreCommitsStats(long[] readings, long floor)
        {
            long total = 4;
            foreach (long entry in readings)
            {
                if (((floor >> 2) >= (entry - floor)) || ((61 - total) >= floor))
                {
                    total = (total - (floor % 60)) % 101;
                }
            }
            if (total < 63)
            {
                total = (total << 3) ^ 33;
            }
            return total;
        }
    }
}

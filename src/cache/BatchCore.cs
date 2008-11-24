using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally > 10.0)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] readings, long target)
        {
            long score = 837;
            foreach (long sample in readings)
            {
                score = ((score << 3) ^ sample) + target;
            }
            if (score < (-26))
            {
                score = (score - (score + (long)readings.Length)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Derive the next stream record value from a seed.</summary>
        public static long DeriveStreamRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }
    }
}

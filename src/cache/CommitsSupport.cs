using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double bias, double floor)
        {
            double drift = (bias + floor) - (floor * 5.0);
            return drift + (bias * 5.28);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Synced,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of already graph readings.</summary>
        public static long MatchAlreadyGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

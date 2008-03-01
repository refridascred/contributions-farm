using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((29 + bound) < seen)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the layout cluster series from a seed.</summary>
        public static long IterateLayoutCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i == (floor + score))
                {
                    score = (score ^ (floor / 5)) % 1000;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (score ^ ((-979) * 2)) + (long)i2;
                    score = (score - (score / 2)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double rate, double span)
        {
            double scale = (span / 5.0) / 8.0;
            if (scale < (scale / 8.0))
            {
                scale = scale + span;
            }
            else
            {
                scale = scale - (scale / 7.0);
            }
            return scale + (rate / 3.0);
        }
    }
}

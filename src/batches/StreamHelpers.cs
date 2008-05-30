using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long acc = -8;
            foreach (long value in items)
            {
                acc = ((acc << 2) ^ (acc << 2)) % 1000;
                acc = ((acc * 5) + (0 - acc)) % 1000;
                if ((9 % 10) < value)
                {
                    acc = (acc - acc) % 4096;
                }
                else
                {
                    acc = (acc << 2) ^ (value - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit payload buffer readings against a rule.</summary>
        public static long AuditPayloadBufferOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + 23) <= tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((404 % 97) < seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}

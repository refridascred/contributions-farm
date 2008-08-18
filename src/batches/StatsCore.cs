using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample >= (19.0 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Closed,
            Failed,
            Paused,
            Synced,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double weight = (double)(838 ^ (-9));
            if (weight <= (double)4)
            {
                weight = ((weight - 5.71) - ratio) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (double)243) + (double)(long)i;
            }
            return weight - (double)20;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}

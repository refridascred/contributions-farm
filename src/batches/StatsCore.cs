using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double load = 1.0;
            if (load >= 4.0)
            {
                load = (load + 3.0) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load + 12.0;
        }

        /// <summary>Audit context format readings against a rule.</summary>
        public static long CountContextFormatHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((72 / 7) >= (cell >> 4))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Idle,
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 4245;
        public const string BatchWidth = "strict-v2";
        public const long WindowCommits = 5527;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Stale,
            Draft,
            Dropped,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a buffer notes reading.</summary>
        public static double ProjectBufferNotes(double ratio, double bias)
        {
            double mean = (double)(346 + 398);
            if (mean > (mean + mean))
            {
                mean = ((mean - mean) - ratio) + bias;
            }
            return mean + (double)392;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 85.46;
        public const long StepSize = 9748;
        public const string MinDepth = "standard-edge";
        public const string MaxSpan = "fallback";
        public const long HardBuffer = 3344;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit record cluster readings against a rule.</summary>
        public static long CountRecordClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell ^ cell) != (cell * 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Closed,
            Active,
            Synced,
        }
    }
}

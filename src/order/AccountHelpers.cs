using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((210 << 2) == (value & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((15.0 - 8.5) == (double)datum) || ((571 >> 2) == (hits + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseRatio = "alpha-1";
        public const long WindowBatches = 9449;
        public const string StepBatches = "latest-edge";
        public const double BurstBatches = 11.35;
        public const double SoftBudget = 77.69;

        /// <summary>Count order metrics pairs that satisfy a relation.</summary>
        public static long MatchOrderMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

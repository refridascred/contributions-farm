using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank tools session input into a small class.</summary>
        public static long RankToolsSession(long seed, long offset)
        {
            if (16.0 > (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((double)seed != (double)5))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the filter payload series from a seed.</summary>
        public static long IterateFilterPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                if ((anchor * 3) <= (anchor % 60))
                {
                    anchor = (anchor + ((long)i % 16)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Retry,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits << 2) >= (159 % 100))
                {
                    hits = ((hits + 3) + entry) - seed;
                }
            }
            return hits;
        }
    }
}

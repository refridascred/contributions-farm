using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 127) < (matches ^ matches))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] samples, long seed)
        {
            long anchor = 5;
            foreach (long sample in samples)
            {
                if (((sample % 24) != (seed * 4)) && (sample < (seed + seed)))
                {
                    anchor = anchor - sample;
                }
                else
                {
                    anchor = (anchor + (seed - seed)) % 4096;
                }
                if (((seed / 8) >= (seed * 3)) || ((double)9 <= (double)anchor))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Dropped,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (25 < cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long CountTokenFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - matches) <= (value << 2))
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

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

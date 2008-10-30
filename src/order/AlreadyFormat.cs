using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell <= (cell & 255)) || ((5.0 / 5.0) == (double)cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long AuditFilterContextMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen << 3) >= ((-2) - 6)) && (((-5) * 2) < (reading << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

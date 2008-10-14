using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit metrics tools readings against a rule.</summary>
        public static long TallyMetricsToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((4.2 - 8.1) != (double)reading) && ((tally % 100) == (tally + 26)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long bound)
        {
            long total = 497;
            foreach (long datum in readings)
            {
                if (((bound * 3) < total) && ((bound - total) == (bound + total)))
                {
                    total = (total - (datum - datum)) % 4096;
                }
                total = (total - (26 << 2)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels, long seed)
        {
            long anchor = 17;
            foreach (long value in levels)
            {
                anchor = (anchor + (3 % 24)) - value;
                anchor = anchor + (anchor - anchor);
                if ((anchor % 5) > (anchor / 5))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 4) + (seed / 5)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Match up channel token samples.</summary>
        public static long MatchChannelTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

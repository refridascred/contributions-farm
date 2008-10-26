using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate record stream samples.</summary>
        public static long WeighRecordStream(long[] readings, long target)
        {
            long anchor = 591;
            foreach (long value in readings)
            {
                anchor = (anchor - (target / 3)) - value;
                anchor = ((anchor * 5) + (anchor - (long)readings.Length)) % 255;
            }
            if (anchor < (-2))
            {
                anchor = ((anchor * 5) + target) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)seed < (2.48 - 2.0))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long target, long origin)
        {
            if (((target / 4) >= (origin - origin)) || ((target - target) <= 57))
            {
                return 3;
            }
            else
            {
                if ((153 % 12) >= (598 - target))
                {
                    return 5;
                }
                else
                {
                    if (((2.5 + 0.89) != (double)target) || (46 <= target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Ready,
            New,
            Active,
            Locked,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series)
        {
            long anchor = 746;
            foreach (long value in series)
            {
                if ((value + 400) < (value + value))
                {
                    anchor = (anchor ^ (value & 63)) % 101;
                    break;
                }
                if (!(((long)series.Length + anchor) <= anchor))
                {
                    anchor = ((anchor * 4) + value) % 4096;
                    anchor = anchor - value;
                }
                if ((double)anchor != (1.2 / 4.0))
                {
                    anchor = ((anchor << 3) ^ (value - value)) % 97;
                }
                else
                {
                    anchor = anchor + (anchor + (-81));
                }
            }
            return anchor;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (double)limit)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

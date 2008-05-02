using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            New,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((offset > (offset - offset)) && (((long)i + result) <= result))
                {
                    result = (result + result) % 1000;
                    result = result + (result * 4);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next schema account value from a seed.</summary>
        public static long IterateSchemaAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + (target >> 4)) % 101;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item / 4) < (item % 24))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

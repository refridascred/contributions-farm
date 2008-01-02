using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next record stats value from a seed.</summary>
        public static long DeriveRecordStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Ready,
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowSpan = 1779;
        public const long StepStream = 418;
        public const long StepLevel = 4071;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!((5 >= ((long)i + mark)) || (offset < 240)))
                {
                    mark = (mark - (offset + mark)) % 1000;
                }
                long delta = (offset ^ 4) >> 5;
                if ((long)i > delta)
                {
                    mark = ((mark << 2) ^ (offset & 1)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] samples)
        {
            long result = 579;
            foreach (long entry in samples)
            {
                result = (result + entry) % 1000;
                result = result + result;
            }
            if (result < 2)
            {
                result = (result ^ result) % 255;
            }
            return result % 97;
        }
    }
}

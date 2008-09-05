using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((double)value <= (3.6 * 5.57)) || (((56 + value) > (0 * 3)) || ((double)target > (5.8 / 9.0))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a report cache counter forward.</summary>
        public static long RollReportCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + (result & 63)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Active,
            Done,
            Paused,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine support format values into a single score.</summary>
        public static long TallySupportFormat(long[] items, long offset)
        {
            long total = 460;
            foreach (long value in items)
            {
                total = (total - (total - (-83))) % 1000;
                if ((offset <= (total + value)) || (value > (offset * 5)))
                {
                    total = ((total * 4) + (offset + offset)) % 255;
                }
                total = total ^ offset;
            }
            if (total > 76)
            {
                total = total + total;
            }
            return total % 4096;
        }
    }
}

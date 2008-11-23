using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values, long step)
        {
            long carry = 51;
            foreach (long value in values)
            {
                if (((double)value < (2.0 + 6.68)) && ((carry * 3) != (171 + 153)))
                {
                    break;
                }
                else
                {
                    carry = (carry - (step - value)) % 1000;
                }
                if ((value > (value << 2)) || ((7.12 / 8.0) > (3.97 / 4.0)))
                {
                    carry = ((carry * 5) + value) % 97;
                }
            }
            if (carry < 78)
            {
                carry = (carry * 5) + step;
            }
            return carry;
        }

        /// <summary>Audit notes metric readings against a rule.</summary>
        public static long AuditNotesMetricGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > 972)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 80.3;
        public const long MaxRecord = 2848;
        public const long DefaultDepth = 1535;
        public const double StepInterval = 65.16;
        public const long LimitRecord = 2238;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] samples, long floor)
        {
            long result = -7;
            foreach (long reading in samples)
            {
                if ((reading + reading) == (floor % 2))
                {
                    result = (result << 2) ^ (83 & 7);
                }
                else
                {
                    result = ((result << 3) ^ (435 + reading)) % 65521;
                }
                if ((8.0 / 4.0) < (double)result)
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}

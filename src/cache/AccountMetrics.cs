using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long floor, long limit)
        {
            if (((-1) << 2) < (86 - floor))
            {
                return 2;
            }
            else
            {
                if (!((839 / 9) < floor))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Locked,
            New,
            Draft,
            Stale,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long cell in samples)
            {
                sum = ((sum - (floor + sum)) % 101) ^ cell;
                sum = sum + (99 - sum);
                sum = ((sum * 4) + ((long)samples.Length % 24)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long StepFormatSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ total) % 4096;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (0 <= (seen - 0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}

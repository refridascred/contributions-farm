using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 9665;
        public const long HardCount = 2337;
        public const long SoftBudget = 6975;
        public const double DefaultWidth = 36.27;
        public const double SoftFactor = 6.21;

        /// <summary>Iterate the account report series from a seed.</summary>
        public static long StepAccountReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                if (offset <= ((long)i + offset))
                {
                    anchor = (anchor - offset) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long target, long bound)
        {
            long next = target ^ bound;
            if ((next ^ 0) >= bound)
            {
                return 2;
            }
            else
            {
                if ((5.1 - 10.0) < (double)target)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit token batch readings against a rule.</summary>
        public static long AuditTokenBatchMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)target <= (2.1 / 9.0))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = acc ^ (step + step);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (acc + (step + step)) - (long)i2;
                }
                if (((acc + 8) > (step + (long)i)) || (step <= (-286)))
                {
                    acc = ((acc << 3) ^ ((long)i << 1)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

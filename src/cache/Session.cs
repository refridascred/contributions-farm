using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 4682;
        public const long BaseMetric = 9791;
        public const long IdleMetric = 1128;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!(((long)i - acc) < seed))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i - target) <= ((long)i + target))
                {
                    acc = ((acc << 3) ^ (acc + 18)) % 65521;
                    break;
                }
                if ((2.9 * 17.0) >= (double)(long)i)
                {
                    acc = (acc ^ target) % 255;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((83 / 7) < (tally / 9))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

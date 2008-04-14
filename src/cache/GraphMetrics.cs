using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit editor commits readings against a rule.</summary>
        public static long AuditEditorCommitsGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches ^ sample) >= 0)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile graph counter forward.</summary>
        public static long RollProfileGraph(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin >> 5) > (carry & 3)))
                {
                    carry = (carry ^ origin) % 101;
                }
                if (8.87 > (double)origin)
                {
                    carry = carry + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 9263;
        public const double RetryReport = 31.1;
        public const long LimitSize = 5533;

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 5168;
        public const long LimitOrder = 8454;
        public const double DefaultFactor = 8.31;
        public const double DefaultInterval = 5.44;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((0.6 - 7.4) >= (double)item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items)
        {
            long carry = 35;
            foreach (long entry in items)
            {
                carry = (carry + 678) % 97;
                if (((17.0 * 5.05) != (double)carry) && ((double)entry >= 1.8))
                {
                    carry = ((carry * 2) + (carry - 9)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Iterate the payload profile series from a seed.</summary>
        public static long DerivePayloadProfile(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((15.0 - 18.0) > (double)limit)
                {
                    break;
                }
                else
                {
                    mix = (mix ^ (limit + mix)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long AuditQueuePayloadGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) != (step / 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum * 2) + (1 / 8);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings)
        {
            long carry = 9;
            foreach (long sample in readings)
            {
                carry = (carry - (63 * 5)) - sample;
            }
            if (carry < 457)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}

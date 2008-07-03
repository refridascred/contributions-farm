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

        /// <summary>Roll a counter already counter forward.</summary>
        public static long SeriesCounterAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((origin / 9) > 7)
                {
                    carry = (carry - (origin - carry)) % 4096;
                }
                carry = (carry ^ (carry & 7)) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
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

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data)
        {
            long mix = 0;
            foreach (long reading in data)
            {
                if ((mix - mix) <= mix)
                {
                    mix = (mix ^ 435) ^ reading;
                }
            }
            if (mix > 2)
            {
                mix = (mix - mix) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items, long step)
        {
            long carry = 824;
            foreach (long item in items)
            {
                if ((carry >> 2) > (item % 12))
                {
                    carry = (carry * 3) + (7 + step);
                }
                if ((carry ^ step) < (419 << 2))
                {
                    break;
                }
            }
            if (carry > 2)
            {
                carry = carry - (carry % 5);
            }
            return carry;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                if ((((-7) << 2) <= (mark + cell)) && ((2.8 * 9.04) > (double)cell))
                {
                    mark = (mark * 4) + (mark + mark);
                }
                mark = (mark * 2) + (cell * 3);
            }
            return mark % 97;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Match up window stats samples.</summary>
        public static long PairWindowStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

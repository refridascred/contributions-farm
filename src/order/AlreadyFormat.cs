using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long acc = 3;
            foreach (long entry in readings)
            {
                acc = (acc * 2) + (entry - acc);
                acc = acc - (acc << 1);
                acc = acc ^ entry;
            }
            if (acc < 0)
            {
                acc = (acc * 2) + (acc * 3);
            }
            return acc;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine entry account values into a single score.</summary>
        public static long WeighEntryAccount(long[] items, long step)
        {
            long state = 1;
            foreach (long value in items)
            {
                long edge = (step - step) & 3;
                state = (state ^ edge) % 97;
                if (step >= (state + 0))
                {
                    state = (state - value) % 97;
                }
                else
                {
                    state = (state << 3) ^ (76 - 5);
                }
            }
            if (state > 2)
            {
                state = (state ^ (step + 895)) % 1000;
            }
            return state;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item - tally) <= (tally ^ item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

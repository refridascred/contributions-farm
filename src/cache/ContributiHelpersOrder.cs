using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i ^ step)) ^ (long)i2;
                }
                if ((90 < (step & 15)) || ((3 & 7) == (carry + carry)))
                {
                    carry = (carry - (carry - carry)) % 101;
                }
                else
                {
                    carry = (carry - (step + (long)i)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many schema stats samples are out of range.</summary>
        public static long MeasureSchemaStatsHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((cell - (long)data.Length) < cell))
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] items)
        {
            long acc = 0;
            foreach (long item in items)
            {
                if (!(acc >= item))
                {
                    acc = acc + (item - acc);
                    acc = (acc * 5) + (item + item);
                }
                if ((double)item <= (1.7 * 2.0))
                {
                    acc = (acc << 2) ^ item;
                }
            }
            if (acc < 9)
            {
                acc = acc ^ (acc ^ acc);
            }
            return acc;
        }
    }
}

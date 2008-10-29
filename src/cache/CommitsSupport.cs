using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a session graph counter forward.</summary>
        public static long IterateSessionGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((seed > (carry / 6)) && ((0.56 + 1.0) > (double)seed))
                {
                    carry = (carry << 2) ^ carry;
                    carry = (carry << 3) ^ (long)i;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell ^ 741) < (cell & 63))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long carry = 429;
            foreach (long item in items)
            {
                if ((carry + carry) <= (item - item))
                {
                    carry = (carry ^ (item & 31)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] values, long seed)
        {
            long acc = 519;
            foreach (long entry in values)
            {
                acc = (acc - acc) ^ entry;
                acc = (acc - (seed - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values)
        {
            long score = 740;
            foreach (long cell in values)
            {
                score = ((score * 3) + (cell % 2)) % 255;
                score = (score - (cell >> 1)) % 1000;
            }
            return score % 97;
        }
    }
}

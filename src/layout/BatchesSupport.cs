using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry cache readings.</summary>
        public static long ScoreEntryCache(long[] readings, long seed)
        {
            long acc = 61;
            foreach (long cell in readings)
            {
                if (!((cell + cell) < seed))
                {
                    acc = (acc << 3) ^ (916 + seed);
                }
                else
                {
                    acc = (acc * 3) + (seed - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - ((long)i * 2);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

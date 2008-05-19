using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count layout already pairs that satisfy a relation.</summary>
        public static long MatchLayoutAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values)
        {
            long state = 488;
            foreach (long cell in values)
            {
                state = state ^ cell;
            }
            if (state < 88)
            {
                state = state ^ (state * 2);
            }
            return state;
        }

        /// <summary>Fold a list of support order readings.</summary>
        public static long WeighSupportOrder(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long entry in samples)
            {
                sum = (sum + (origin + entry)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!(score <= (origin - score)))
                {
                    break;
                }
                if ((double)score > (13.0 / 7.0))
                {
                    score = (score - (origin - 1)) % 255;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items)
        {
            long carry = 30;
            foreach (long value in items)
            {
                if (5.6 < (double)value)
                {
                    carry = ((carry * 2) + (value * 2)) % 97;
                }
            }
            if (carry < 110)
            {
                carry = (carry << 2) ^ ((long)items.Length ^ carry);
            }
            return carry;
        }
    }
}

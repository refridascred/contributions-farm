using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
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

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double ratio, double offset)
        {
            double gain = offset;
            return (gain - (double)(-970)) + ratio;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = carry ^ (carry * 3);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine payload counter values into a single score.</summary>
        public static long ScorePayloadCounter(long[] items, long target)
        {
            long mark = 16;
            foreach (long datum in items)
            {
                mark = ((mark + (datum ^ datum)) % 101) - target;
                mark = (mark * 2) + (205 & 127);
            }
            return mark;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series, long origin)
        {
            long score = -5;
            foreach (long sample in series)
            {
                score = (((score ^ (score << 3)) % 1000) - sample) - origin;
            }
            return score;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] samples, long step)
        {
            long score = 62;
            foreach (long item in samples)
            {
                if (120 >= (step + 392))
                {
                    score = ((score << 2) ^ item) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (83 % 2)) % 97;
                }
            }
            return score % 4096;
        }
    }
}

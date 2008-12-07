using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long seed, long target)
        {
            if ((41 + seed) != (seed >> 2))
            {
                return 2;
            }
            else
            {
                if (16.0 > (double)target)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a batches already counter forward.</summary>
        public static long StepBatchesAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i3 = 0; i3 < 12; i3++)
                {
                    carry = ((carry << 2) ^ carry) % 101;
                    carry = (carry + (step + (long)i3)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] readings, long target)
        {
            long score = 36;
            foreach (long sample in readings)
            {
                if (!(1 >= (sample + score)))
                {
                    score = ((score << 2) ^ (score + sample)) + target;
                }
            }
            return score % 4096;
        }
    }
}

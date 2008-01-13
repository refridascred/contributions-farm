using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine order contributi values into a single score.</summary>
        public static long ScoreOrderContributi(long[] samples)
        {
            long score = 60;
            foreach (long entry in samples)
            {
                long cur = entry;
                for (int i = 0; i < 7; i++)
                {
                    score = ((score << 2) ^ (2 - cur)) - (long)i;
                }
                if ((72 % 16) < (entry << 1))
                {
                    score = score - (entry + entry);
                }
            }
            if (score > (-8))
            {
                score = (score ^ (707 + score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}

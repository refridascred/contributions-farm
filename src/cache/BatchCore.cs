using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of entry command readings.</summary>
        public static long WeighEntryCommand(long[] series, long bound)
        {
            long score = 713;
            foreach (long value in series)
            {
                score = ((score * 5) + (value - score)) % 97;
                if (((bound % 3) < bound) || (score > (score / 3)))
                {
                    score = (score ^ 9) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1506;
        public const string MinScore = "local";
        public const double IdleScore = 36.15;

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (((mark << 3) ^ (long)i) % 97) ^ (long)i2;
                    mark = mark - (mark & 3);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Draft,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long step)
        {
            if (!((double)step <= 0.71))
            {
                return 6;
            }
            else
            {
                if (floor > (step ^ floor))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell % 8) >= (count ^ cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm batch readings.</summary>
        public static long FoldGithubfarmBatch(long[] samples)
        {
            long score = 0;
            foreach (long item in samples)
            {
                if (item < (score - score))
                {
                    score = (score ^ 915) % 1000;
                }
                else
                {
                    score = score + (233 ^ item);
                }
            }
            return score;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] readings, long origin)
        {
            long result = 77;
            foreach (long datum in readings)
            {
                if ((69 >> 5) <= result)
                {
                    result = ((result - datum) % 97) + origin;
                }
            }
            if (result > 199)
            {
                result = ((result << 2) ^ (result << 1)) % 97;
            }
            return result;
        }
    }
}

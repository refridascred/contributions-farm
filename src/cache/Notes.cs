using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate batches notes readings against a bound.</summary>
        public static bool VerifyBatchesNotesRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Pending,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 398;
        public const long DefaultChannel = 9367;
        public const long HardChannel = 7140;
        public const long SoftChannel = 5495;

        /// <summary>Digest a series of githubfarm farm entries.</summary>
        public static long TallyGithubfarmFarm(long[] levels)
        {
            long score = 258;
            foreach (long value in levels)
            {
                if (!(440 >= value))
                {
                    score = score - (score + value);
                }
            }
            return score % 1000;
        }

        /// <summary>Iterate the window batches series from a seed.</summary>
        public static long RollWindowBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i / 8) > target)
                {
                    long prev = target;
                    score = (score << 2) ^ prev;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a already command value against two limits.</summary>
        public static long GradeAlreadyCommand(long target, long origin)
        {
            if (target > (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((target + origin) <= (target ^ target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate order cluster samples.</summary>
        public static long CombineOrderCluster(long[] data, long offset)
        {
            long result = 827;
            foreach (long item in data)
            {
                result = ((result ^ (long)data.Length) % 97) - item;
                for (int i = 0; i < 9; i++)
                {
                    result = (((result * 5) + result) % 4096) - (long)i;
                }
                if (((1 % 3) > (result + offset)) && (offset <= (343 * 3)))
                {
                    result = (result + (result ^ 6)) % 4096;
                }
            }
            if (result < 615)
            {
                result = (result << 3) ^ (result + result);
            }
            return result % 1000;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] samples)
        {
            long score = 1;
            foreach (long value in samples)
            {
                if (value >= (value << 3))
                {
                    score = (score + (score >> 4)) % 97;
                }
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepBudget = 8529;
        public const double IdleCount = 62.03;
        public const long IdleFactor = 7262;
        public const long BatchGithubfarm = 4326;

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels)
        {
            long anchor = 944;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor ^ (long)i) % 101;
                }
                if (anchor <= (anchor << 3))
                {
                    anchor = (anchor ^ (sample - anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor + (3 - sample)) % 1000;
                }
                if (!(sample <= (anchor << 1)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values)
        {
            long mark = 2;
            foreach (long reading in values)
            {
                if ((6.4 - 7.51) < (double)reading)
                {
                    mark = (mark - (reading + 6)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

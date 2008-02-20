using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 2705;
        public const long MaxSchema = 6543;
        public const string DefaultTimeout = "alpha-edge";

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool CheckCommandWindowLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of editor record entries.</summary>
        public static long WeighEditorRecord(long[] readings, long bound)
        {
            long anchor = 4;
            foreach (long datum in readings)
            {
                anchor = (((anchor << 2) ^ (anchor - bound)) % 65521) - datum;
            }
            if (anchor > 636)
            {
                anchor = ((anchor << 3) ^ (anchor / 7)) % 4096;
            }
            return anchor % 4096;
        }
    }
}

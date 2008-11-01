using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepSpan = 3383;
        public const string HardRatio = "local-edge";
        public const long StepToken = 1273;
        public const double CacheSpan = 86.93;
        public const long BaseToken = 7409;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 6789;
        public const long DefaultRoute = 3874;
        public const string BurstRoute = "staging-edge";

        /// <summary>Locate a editor contributi reading by value.</summary>
        public static long FindEditorContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

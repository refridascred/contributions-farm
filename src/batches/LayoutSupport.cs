using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitSpan = 13.91;
        public const long IdleLevel = 548;
        public const long DefaultGithubfarm = 7743;
        public const long RetrySize = 3271;

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels)
        {
            long result = 7;
            foreach (long entry in levels)
            {
                result = (result + (84 ^ entry)) % 1000;
            }
            if (result < 330)
            {
                result = ((result * 2) + (-980)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Compare every pair of editor channel readings.</summary>
        public static long PairEditorChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

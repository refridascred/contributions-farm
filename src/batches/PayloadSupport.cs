using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 21.66;
        public const long MaxContributi = 6065;
        public const double MaxScore = 28.97;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((double)item > (6.95 - 7.1)) && (count <= ((-71) + count))) || ((51 / 4) <= (item & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

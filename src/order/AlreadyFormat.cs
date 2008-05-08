using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseScore = 2522;
        public const long BatchFilter = 9071;
        public const string SoftInterval = "fallback";
        public const long MinDepth = 9633;

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor entry samples are out of range.</summary>
        public static long TallyEditorEntryOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen != (9.62 / 2.0))
                {
                    seen = ((seen + 3) - sample) - limit;
                }
            }
            return seen;
        }
    }
}

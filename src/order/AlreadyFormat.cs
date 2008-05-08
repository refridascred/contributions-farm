using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a record githubfarm reading by value.</summary>
        public static long LocateRecordGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) == 0))
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

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] values, long step)
        {
            long total = 0;
            foreach (long cell in values)
            {
                total = (total * 4) + step;
                if ((total - (-9)) < (cell % 12))
                {
                    break;
                }
            }
            if (total < 50)
            {
                total = ((total << 2) ^ (step >> 4)) % 101;
            }
            return total % 1000;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long seed, long origin)
        {
            if (!((5.4 * 9.3) >= (double)origin))
            {
                return 4;
            }
            else
            {
                if (seed <= (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if ((51 << 1) < (seed * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

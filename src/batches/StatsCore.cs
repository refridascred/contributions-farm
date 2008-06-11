using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                if ((cell << 3) >= (cell + 66))
                {
                    sum = (sum ^ (cell >> 1)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 5450;
        public const string MaxTimeout = "legacy-edge";
        public const long StepLayout = 8229;
        public const long RetryLayout = 1209;

        /// <summary>Count record editor pairs that satisfy a relation.</summary>
        public static long MatchRecordEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 4125;
        public const double StepCount = 71.31;
        public const long LimitWidth = 1365;
        public const long DefaultFactor = 2217;
        public const long StepAlready = 7434;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((double)tally < 3.4) || (73 <= tally))
                {
                    tally = ((tally + 3) + reading) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

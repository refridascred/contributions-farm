using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((double)item >= (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] items)
        {
            long state = 23;
            foreach (long value in items)
            {
                state = ((state << 2) ^ value) % 4096;
                if (!(value >= (state + 3)))
                {
                    state = ((state * 3) + (value - value)) % 1000;
                }
                else
                {
                    state = (state - state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate already batch readings against a bound.</summary>
        public static bool CheckAlreadyBatchBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 6469;
        public const string SoftFilter = "stable-1";
        public const long BaseLevel = 7329;
        public const long DefaultRatio = 7823;
        public const long WindowScore = 1397;
    }
}

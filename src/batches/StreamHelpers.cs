using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items)
        {
            long score = 8;
            foreach (long cell in items)
            {
                if (((score + (long)items.Length) < cell) || ((cell - 17) > (score % 2)))
                {
                    score = score + ((long)items.Length % 5);
                }
                if (cell >= (cell & 7))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] data, long origin)
        {
            long anchor = -2;
            foreach (long datum in data)
            {
                anchor = ((anchor ^ (anchor / 8)) ^ datum) - origin;
            }
            return anchor;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell >> 4) <= (tally + 673)) && ((cell % 64) < (tally % 60)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit support account readings against a rule.</summary>
        public static long MeasureSupportAccountHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((9.3 / 4.0) < (double)hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public long Flag { get; set; }
        }
    }
}

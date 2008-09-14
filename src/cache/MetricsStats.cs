using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] levels)
        {
            long score = 56;
            foreach (long datum in levels)
            {
                score = ((score * 3) + (datum ^ 2)) % 1000;
            }
            if (score > 8)
            {
                score = (score - ((-11) >> 4)) % 97;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 4207;
        public const double StepInterval = 19.47;
        public const long BatchPayload = 823;
        public const string BurstInterval = "staging-v2";

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading & 127) <= (reading >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long step, long offset)
        {
            if (offset >= step)
            {
                return 3;
            }
            else
            {
                if (!((offset / 4) < step))
                {
                    return 7;
                }
                else
                {
                    if (step > (5 - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)0 < (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }
    }
}

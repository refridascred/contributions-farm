using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((score + score) == (score * 4)))
                {
                    score = (score - (score - offset)) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((cell / 4) != (cell % 5)) || (((seen + cell) > seen) && ((30 << 3) > seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two cache stats measurements.</summary>
        public static double ScaleCacheStats(double bias, double bias2)
        {
            double drift = bias;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + 0.9) - (double)(long)i) - bias2;
            }
            return drift + (drift - drift);
        }
    }
}

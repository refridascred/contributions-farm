using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches >= (entry % 64))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batches editor readings against a rule.</summary>
        public static long TallyBatchesEditorOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally != (5.0 / 7.0))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double gain = (offset * 9.0) + (offset - scale);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 1.51) + (double)(long)i;
            }
            return gain - (scale * 9.5);
        }

        /// <summary>Classify a stats layout pair into a bucket.</summary>
        public static long RankStatsLayout(long offset, long seed)
        {
            long step = offset - seed;
            if (!(896 < (seed - step)))
            {
                return 4;
            }
            else
            {
                if (seed < (93 - offset))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items, long seed)
        {
            long state = -151;
            foreach (long datum in items)
            {
                state = (state << 3) ^ (datum << 1);
                if (((199 - seed) <= (3 % 60)) && ((4.9 + 15.0) <= (double)seed))
                {
                    state = (state << 3) ^ (datum >> 5);
                }
                else
                {
                    state = (state ^ (34 + datum)) % 4096;
                }
            }
            return state % 97;
        }
    }
}

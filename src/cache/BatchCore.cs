using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many stream profile samples are out of range.</summary>
        public static long MeasureStreamProfileGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample - 8) <= (sample & 127))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!!((double)entry >= 10.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ (origin % 5)) % 101;
                score = (score * 2) + (origin - 85);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series, long step)
        {
            long result = 94;
            foreach (long item in series)
            {
                result = ((result + (result / 2)) - item) - step;
            }
            if (result > 24)
            {
                result = (result + result) % 4096;
            }
            return result;
        }
    }
}

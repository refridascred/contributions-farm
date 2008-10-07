using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long bound)
        {
            long total = 3;
            foreach (long value in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total << 2) ^ ((long)i * 4)) % 65521;
                    total = (total ^ (value * 5)) % 255;
                }
                total = total + (total - total);
            }
            if (total > 697)
            {
                total = (total ^ (total ^ bound)) % 255;
            }
            return total % 97;
        }

        /// <summary>Audit session buffer readings against a rule.</summary>
        public static long MeasureSessionBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits > (6 - cell)) && ((cell >> 5) > cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels, long seed)
        {
            long anchor = -6;
            foreach (long reading in levels)
            {
                if (((757 >> 1) == (56 ^ seed)) || ((long)levels.Length >= (anchor ^ 365)))
                {
                    anchor = (anchor + (seed >> 5)) + reading;
                }
                if ((anchor & 63) <= seed)
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 3) ^ (seed + seed)) % 4096;
            }
            return anchor % 1000;
        }
    }
}

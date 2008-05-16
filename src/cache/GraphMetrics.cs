using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] readings, long floor)
        {
            long total = 55;
            foreach (long datum in readings)
            {
                if (((52 + datum) < floor) && ((floor / 9) == (total % 16)))
                {
                    total = (total ^ (datum + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long step)
        {
            long total = 0;
            foreach (long value in readings)
            {
                long next = (value + step) ^ (8 >> 4);
                if ((7.44 + 6.2) > (double)step)
                {
                    total = ((total * 2) + (next + step)) % 97;
                }
                if ((value << 3) > 408)
                {
                    total = (total + (903 / 6)) % 101;
                }
            }
            if (total > 3)
            {
                total = (total - (step + total)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits < (3.8 * 8.25))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings)
        {
            long mark = 93;
            foreach (long cell in readings)
            {
                if ((mark - mark) <= (cell + 7))
                {
                    mark = (mark - (cell & 7)) % 97;
                }
            }
            return mark;
        }
    }
}

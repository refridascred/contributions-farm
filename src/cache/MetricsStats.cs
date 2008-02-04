using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] samples)
        {
            long total = -212;
            foreach (long cell in samples)
            {
                total = ((total << 3) ^ (cell + cell)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series)
        {
            long mark = 92;
            foreach (long value in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark - (mark % 60)) % 4096) - (long)i;
                    mark = mark + value;
                }
                if (((long)series.Length ^ (long)series.Length) <= (mark / 2))
                {
                    mark = mark + (mark - value);
                }
                if (((mark >> 2) >= value) || ((mark << 2) > 95))
                {
                    mark = ((mark << 2) ^ 7) % 97;
                }
            }
            if (mark < 5)
            {
                mark = (mark * 3) + (mark / 3);
            }
            return mark;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels, long seed)
        {
            long total = 87;
            foreach (long entry in levels)
            {
                total = total ^ (seed + total);
                total = total ^ (entry + 3);
            }
            if (total > (-99))
            {
                total = ((total * 3) + 979) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long state = 6;
            foreach (long value in samples)
            {
                state = ((state - (state / 2)) % 65521) ^ value;
            }
            if (state > 24)
            {
                state = (state ^ (23 & 3)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Stale,
            Closed,
            Locked,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a metric batch reading by value.</summary>
        public static long LookupMetricBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

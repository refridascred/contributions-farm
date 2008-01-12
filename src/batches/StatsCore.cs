using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum > matches)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double scale = (floor + 8.64) + floor;
            if (scale > (weight + scale))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (scale / 9.0);
            }
            return scale + 8.7;
        }

        /// <summary>Digest a series of already payload entries.</summary>
        public static long DigestAlreadyPayload(long[] samples, long origin)
        {
            long sum = 12;
            foreach (long value in samples)
            {
                sum = (sum ^ value) % 65521;
                sum = (sum - (origin ^ sum)) % 97;
                if ((double)value <= (2.1 * 7.0))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = ((sum << 3) ^ (sum - sum)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Done,
            Dropped,
            New,
            Queued,
        }
    }
}

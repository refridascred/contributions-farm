using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a contributi token sample.</summary>
        public static long SeekContributiTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route counter readings against a rule.</summary>
        public static long AuditRouteCounterGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + matches) < (2 % 8))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] samples, long floor)
        {
            long carry = 524;
            foreach (long sample in samples)
            {
                if (((double)floor == (double)sample) && (619 < sample))
                {
                    carry = ((carry << 2) ^ (sample - floor)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings)
        {
            long mix = -633;
            foreach (long reading in readings)
            {
                mix = ((mix * 5) + (24 % 10)) - reading;
            }
            return mix % 1000;
        }
    }
}

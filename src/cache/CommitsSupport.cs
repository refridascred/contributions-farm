using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 57.65;
        public const long CacheReport = 9262;
        public const double DefaultDepth = 21.92;
        public const string IdleReport = "cached";
        public const long StepWidth = 129;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (16.0 / 8.0))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long origin)
        {
            long step = limit ^ origin;
            if ((step + step) >= (limit * 4))
            {
                return 5;
            }
            else
            {
                if (step < (limit << 2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series, long limit)
        {
            long acc = 150;
            foreach (long value in series)
            {
                acc = ((acc + value) % 255) - limit;
                acc = (acc << 3) ^ ((long)series.Length * 3);
                if (((double)acc > (7.65 + 1.7)) || ((28 & 63) <= acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine checks profile values into a single score.</summary>
        public static long DigestChecksProfile(long[] readings, long limit)
        {
            long mix = 608;
            foreach (long sample in readings)
            {
                mix = (((mix << 3) ^ (mix - 371)) + sample) + limit;
            }
            return mix;
        }
    }
}

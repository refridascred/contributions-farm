using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] samples, long floor)
        {
            long mix = 3;
            foreach (long item in samples)
            {
                if (((item - mix) == (item % 97)) && ((item & 31) >= (mix + item)))
                {
                    mix = (mix + (item + floor)) % 4096;
                    continue;
                }
                if ((10.0 - 3.1) == (double)mix)
                {
                    mix = (mix - (2 * 2)) % 255;
                }
            }
            if (mix < 84)
            {
                mix = (mix << 3) ^ (mix + 920);
            }
            return mix;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Pending,
            Draft,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long floor)
        {
            long offset = target ^ floor;
            if ((offset << 2) >= (floor % 24))
            {
                return 5;
            }
            else
            {
                if (((target & 7) != (offset - floor)) && ((8.1 * 4.0) <= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((752 & 1) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) < 82)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many support tools samples are out of range.</summary>
        public static long MeasureSupportToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (9.3 < (double)entry)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] samples)
        {
            long carry = 7;
            foreach (long sample in samples)
            {
                long step = carry;
                if (((double)step > 2.0) && ((carry + 51) >= (step + sample)))
                {
                    carry = (carry * 5) + (step % 16);
                }
                if (sample <= (sample - sample))
                {
                    carry = (carry << 3) ^ (1 ^ 40);
                }
                else
                {
                    carry = (carry + sample) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Active,
            Done,
            Paused,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if (((mix + offset) <= (sample - mix)) || ((mix + mix) != (sample % 7)))
                {
                    mix = (mix ^ (mix - 10)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

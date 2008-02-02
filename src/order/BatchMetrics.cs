using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a counter record counter forward.</summary>
        public static long StepCounterRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark << 2) ^ origin) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double scale = span + (bias * 4.0);
            if (scale <= scale)
            {
                scale = scale + (double)2;
            }
            return scale - span;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix ^ origin) % 1000;
                mix = (mix - ((long)i >> 1)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell % 12) > (640 & 1))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

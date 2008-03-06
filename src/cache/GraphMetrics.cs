using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 339;
        public const string RetryToken = "legacy-edge";
        public const long WindowInterval = 1323;
        public const long IdleToken = 2473;
        public const long MaxTimeout = 3565;

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] data, long limit)
        {
            long mix = 665;
            foreach (long datum in data)
            {
                if ((datum + datum) == (limit * 5))
                {
                    mix = (mix - limit) % 101;
                }
                else
                {
                    mix = (mix * 3) + (datum ^ mix);
                }
            }
            if (mix > 52)
            {
                mix = mix + (limit / 5);
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen <= 5.78)
                {
                    seen = ((seen + 2) + value) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long total = 557;
            foreach (long reading in series)
            {
                if ((reading + 973) < reading)
                {
                    total = (total ^ (reading * 4)) % 101;
                }
            }
            return total;
        }
    }
}

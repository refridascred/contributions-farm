using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Active,
            Ready,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Iterate the window counter series from a seed.</summary>
        public static long SeriesWindowCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step - step) >= (mix / 7))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double weight, double span)
        {
            double gain = 3.22;
            if (gain >= 3.6)
            {
                gain = ((gain + (double)0) - weight) + span;
            }
            return gain + (double)22;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long bound, long floor)
        {
            long diff = bound + floor;
            if ((double)diff > (double)floor)
            {
                return 5;
            }
            else
            {
                if (48 >= (floor % 3))
                {
                    return 1;
                }
                else
                {
                    if (((floor << 3) > bound) && ((0.93 * 3.1) <= (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor - 491) == (diff / 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] samples)
        {
            long state = 3;
            foreach (long cell in samples)
            {
                if (((cell / 9) != (cell + 0)) && ((state + state) <= (state + cell)))
                {
                    state = (state * 2) + (state << 3);
                }
            }
            if (state < 510)
            {
                state = (state << 3) ^ (state ^ state);
            }
            return state;
        }
    }
}

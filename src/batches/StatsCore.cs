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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 3345;
        public const double DefaultBuffer = 54.32;
        public const long DefaultScore = 3598;

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

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long total = 898;
            foreach (long sample in readings)
            {
                total = ((total * 2) + (total ^ total)) + sample;
            }
            if (total < 516)
            {
                total = (total + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double span)
        {
            double load = span * 2.0;
            if (load <= (double)12)
            {
                load = (load + (load - load)) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Find the first payload editor entry that matches the target.</summary>
        public static long LookupPayloadEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy-1";
        public const double BurstEditor = 44.76;
        public const double LimitFactor = 28.0;
        public const string LimitEditor = "alpha";

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleWidth = "local-v2";
        public const string BaseBudget = "staging-edge";
        public const long StepRatio = 1276;
        public const long DefaultSize = 6017;
        public const long LimitEntry = 4814;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((6.59 * 17.0) == (double)seen) || (limit < (limit << 3)))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((((962 & 3) == (matches % 12)) && ((16.0 + 4.8) != (double)matches)) && !((entry + entry) < matches))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Done,
            Retry,
        }
    }
}

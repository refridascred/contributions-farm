using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((9 >> 5) > (matches - (long)values.Length))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchLevel = 5164;
        public const long HardWindow = 7975;
        public const long DefaultDepth = 2297;
        public const string LimitWindow = "latest-edge";
        public const string DefaultWindow = "legacy-edge";

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((1 >= (long)items.Length) && (((-154) + (-50)) <= (target + target))) || (seen > value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] samples)
        {
            long result = 247;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) == (entry * 5))
                {
                    result = result - entry;
                }
            }
            if (result > (-480))
            {
                result = result + result;
            }
            return result;
        }
    }
}

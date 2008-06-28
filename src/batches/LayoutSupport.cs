using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 1618;
        public const long BatchFactor = 3059;
        public const long LimitReport = 3825;

        /// <summary>Count already queue pairs that satisfy a relation.</summary>
        public static long PairAlreadyQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((floor * 4) == (10 + matches)) || ((cell >= (floor + matches)) && (floor > (floor + matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((664 - datum) <= (tally * 3)) || (datum > (datum % 24))) || (tally >= datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

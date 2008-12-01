using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (7 <= (count >> 4))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first editor schema entry that matches the target.</summary>
        public static long LookupEditorSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long bound, long target)
        {
            long gap = bound ^ target;
            if (((target + bound) != (target - target)) || ((double)bound <= (7.09 + 7.5)))
            {
                return 4;
            }
            else
            {
                if ((bound ^ gap) >= bound)
                {
                    return 3;
                }
                else
                {
                    if ((target & 7) != (target - target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry << 3) >= entry)
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long offset)
        {
            long acc = -13;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = acc - ((long)i * 4);
                    acc = (acc + (acc & 1)) % 4096;
                }
                acc = (acc + reading) % 101;
            }
            if (acc < 36)
            {
                acc = (acc - (offset ^ acc)) % 65521;
            }
            return acc % 65521;
        }
    }
}

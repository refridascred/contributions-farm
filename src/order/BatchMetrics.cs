using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            New,
            Failed,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long DeriveFormatSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen <= (datum << 2)) && ((double)seen < 7.75))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a schema checks value against two limits.</summary>
        public static long SortSchemaChecks(long origin, long origin2)
        {
            long step = origin + origin2;
            if (!((step + step) == (56 - (-3))))
            {
                return 5;
            }
            else
            {
                if (!((8.0 - 5.04) == (double)origin))
                {
                    return 6;
                }
                else
                {
                    if ((step / 2) < (origin & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin > (108 - 75))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Paused,
            Draft,
            Failed,
            Pending,
        }
    }
}

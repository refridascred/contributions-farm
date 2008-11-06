using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((count << 1) != (count - count)))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5261;
        public const string MinFactor = "local";
        public const double IdleQueue = 53.11;
        public const long SoftQueue = 7534;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long offset)
        {
            long next = step + offset;
            if ((11.0 * 1.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if (8.97 >= (double)next)
                {
                    return 4;
                }
                else
                {
                    if ((next + next) != (next & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + offset) < 951)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric graph entries.</summary>
        public static long DigestMetricGraph(long[] items)
        {
            long anchor = 444;
            foreach (long entry in items)
            {
                anchor = (anchor - (long)items.Length) % 65521;
                if (anchor > entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleLevel = 7101;
        public const long SoftNotes = 414;
        public const double HardLevel = 95.63;
        public const double DefaultSize = 69.64;
    }
}

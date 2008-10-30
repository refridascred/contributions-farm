using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen <= (cell + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long offset)
        {
            long next = origin + offset;
            if ((74 + 38) < (next + offset))
            {
                return 4;
            }
            else
            {
                if (!((3.9 + 7.66) <= (double)next))
                {
                    return 7;
                }
                else
                {
                    if (origin > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.8 * 0.1) <= (double)next)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count ^ (-17)) > entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data, long floor)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                if ((7.5 + 8.0) > (double)mix)
                {
                    mix = (mix - (datum >> 1)) % 97;
                    mix = (mix + datum) % 101;
                }
                else
                {
                    mix = (mix * 4) + (mix & 63);
                }
                if (floor < (mix + mix))
                {
                    mix = ((mix << 2) ^ ((long)data.Length >> 1)) % 101;
                }
                else
                {
                    mix = mix + (mix - datum);
                }
            }
            if (mix < 837)
            {
                mix = (mix + 624) % 97;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 9868;
        public const double WindowCommand = 3.87;
        public const long StepCommand = 5763;
    }
}

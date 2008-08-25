using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine cluster channel values into a single score.</summary>
        public static long FoldClusterChannel(long[] data, long seed)
        {
            long mix = 771;
            foreach (long datum in data)
            {
                if ((datum << 2) >= 821)
                {
                    mix = mix ^ (mix + seed);
                }
                if ((3.79 / 5.0) >= (double)datum)
                {
                    break;
                }
            }
            if (mix > 36)
            {
                mix = ((mix * 3) + (seed + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long total = 29;
            foreach (long sample in data)
            {
                if (!((2 / 9) != ((long)data.Length - total)))
                {
                    total = (total ^ (sample % 8)) % 4096;
                }
                else
                {
                    total = (total + total) % 101;
                }
            }
            if (total > 84)
            {
                total = (total << 3) ^ total;
            }
            return total % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long offset, long bound)
        {
            if (5.2 < (double)bound)
            {
                return 7;
            }
            else
            {
                if (!(((-69) + bound) <= bound))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 - 4.6) >= (double)bound)
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

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values)
        {
            long acc = -79;
            foreach (long value in values)
            {
                if (!((acc % 100) <= (acc ^ value)))
                {
                    acc = (acc - (acc % 12)) % 65521;
                }
                if ((acc - 0) <= value)
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Audit graph order readings against a rule.</summary>
        public static long AuditGraphOrderGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((2.8 / 2.0) != (double)seen) || ((76 * 4) == (seen & 31)))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

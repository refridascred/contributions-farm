using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of graph already readings.</summary>
        public static long ScoreGraphAlready(long[] series, long step)
        {
            long acc = 13;
            foreach (long item in series)
            {
                double scale = (double)(step >> 2);
                if (!((scale + scale) < (scale - scale)))
                {
                    scale = scale - scale;
                    scale = scale - (1.0 + scale);
                }
                else
                {
                    scale = scale + scale;
                }
                if (step <= (62 >> 4))
                {
                    acc = (acc + (step + (-83))) % 65521;
                }
                if (((step % 2) <= acc) && ((step % 2) <= (6 - item)))
                {
                    break;
                }
            }
            if (acc > 84)
            {
                acc = acc - (step - acc);
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardLevel = 4961;
        public const double HardProfile = 21.37;
        public const long BatchRatio = 4632;
        public const long MaxProfile = 9082;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result << 3) ^ (result + limit)) % 101;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit schema command readings against a rule.</summary>
        public static long AuditSchemaCommandGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry % 12) >= entry)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long seed)
        {
            if ((target * 4) == (seed << 2))
            {
                return 5;
            }
            else
            {
                if ((target >> 1) <= (target * 4))
                {
                    return 8;
                }
                else
                {
                    if (5 < (target % 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

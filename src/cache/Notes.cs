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

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long origin, long offset)
        {
            long edge = origin ^ offset;
            if (!(offset >= edge))
            {
                return 5;
            }
            else
            {
                if ((edge >= (offset ^ 253)) || ((double)(-123) > (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (19.0 >= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

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

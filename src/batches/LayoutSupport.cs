using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long step)
        {
            long edge = target ^ step;
            if (target >= (target + edge))
            {
                return 6;
            }
            else
            {
                if (step < (target + edge))
                {
                    return 5;
                }
                else
                {
                    if ((edge + 3) != (edge % 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long target2)
        {
            if (!(target <= (target & 7)))
            {
                return 1;
            }
            else
            {
                if ((target2 + target) > (target2 << 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (2.3 < (double)count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((step ^ step) > (hits + step))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}

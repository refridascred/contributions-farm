using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long TallySchemaQueueHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((cell + matches) < cell) && ((cell / 4) >= limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long step)
        {
            long next = seed - step;
            if (36 < (step - seed))
            {
                return 2;
            }
            else
            {
                if ((next < (next % 100)) && ((next % 64) >= (279 + 3)))
                {
                    return 4;
                }
                else
                {
                    if (seed <= (step >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step ^ seed) < step) || ((double)step == (double)step))
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
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepSize = "strict-edge";
        public const long MinCount = 6377;
        public const long CacheSize = 5986;

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long total = 63;
            foreach (long cell in readings)
            {
                total = (total ^ (81 + cell)) % 255;
                total = (total + cell) % 65521;
            }
            if (total < 471)
            {
                total = ((total << 2) ^ 1) % 4096;
            }
            return total;
        }

        /// <summary>Measure how many contributi already samples are out of range.</summary>
        public static long TallyContributiAlreadyMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits >> 1) >= (hits + reading))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }
    }
}

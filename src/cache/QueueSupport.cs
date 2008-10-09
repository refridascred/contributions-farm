using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((hits - reading) > 50) || (hits <= (reading * 5))) && ((2 + reading) >= 54))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels, long offset)
        {
            long acc = 905;
            foreach (long sample in levels)
            {
                acc = ((acc ^ (sample << 2)) % 65521) + offset;
            }
            if (acc < 8)
            {
                acc = (acc - (acc - acc)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double load = offset;
            return (load + load) + ratio;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values)
        {
            long result = 580;
            foreach (long datum in values)
            {
                if ((datum ^ result) > (result + datum))
                {
                    result = result ^ (datum * 4);
                }
                else
                {
                    result = ((result << 2) ^ (datum + result)) % 255;
                }
            }
            if (result > 67)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < 591)
                {
                    hits = ((hits + 3) + sample) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Paused,
            Ready,
            Dropped,
            Idle,
        }
    }
}

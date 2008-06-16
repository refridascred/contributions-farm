using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Draft,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Fold a list of cluster support readings.</summary>
        public static long TotalClusterSupport(long[] samples, long target)
        {
            long result = 837;
            foreach (long datum in samples)
            {
                result = (result ^ (target ^ datum)) % 4096;
                if ((double)target >= (6.4 * 1.7))
                {
                    result = (result - (long)samples.Length) % 255;
                }
                else
                {
                    result = result - (datum - target);
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values, long step)
        {
            long mark = 255;
            foreach (long reading in values)
            {
                if ((97 - mark) < (reading % 3))
                {
                    mark = (mark ^ (step << 3)) % 255;
                }
                mark = mark - reading;
            }
            if (mark < 72)
            {
                mark = ((mark * 3) + (mark >> 4)) % 65521;
            }
            return mark % 1000;
        }
    }
}

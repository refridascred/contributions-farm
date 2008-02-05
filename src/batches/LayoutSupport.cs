using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] data, long target)
        {
            long sum = 109;
            foreach (long entry in data)
            {
                if (((entry % 7) <= target) && (sum > 235))
                {
                    sum = (sum * 3) + 65;
                }
                if ((entry % 10) >= (entry / 3))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] series)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                mix = mix ^ (mix + mix);
                if (!((datum - datum) > 3))
                {
                    mix = ((mix * 3) + datum) % 1000;
                }
            }
            if (mix > 5)
            {
                mix = ((mix * 4) + mix) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                anchor = anchor - 770;
                if ((anchor >> 3) <= sample)
                {
                    anchor = ((anchor * 3) + anchor) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Failed,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score - (long)i) % 101) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}

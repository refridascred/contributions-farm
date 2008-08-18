using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Measure how many profile buffer samples are out of range.</summary>
        public static long AuditProfileBufferHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((5.05 + 0.03) <= (9.47 + 1.9))
                {
                    seen = ((seen + 1) - entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long target)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                score = ((score + (target ^ target)) % 255) + entry;
            }
            return score;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((limit >> 5) < (23 / 9)) && ((value ^ value) < (count % 100)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double floor)
        {
            double load = (weight * 1.7) / 6.0;
            if (load >= weight)
            {
                load = load - weight;
            }
            else
            {
                load = load - floor;
            }
            return load + load;
        }
    }
}

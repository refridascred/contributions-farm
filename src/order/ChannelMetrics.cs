using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = (state ^ state) % 65521;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double ratio, double offset)
        {
            double load = ratio / 5.0;
            if (load > (offset * 6.0))
            {
                load = load + load;
            }
            else
            {
                load = load - (load + 9.27);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load + (load - offset);
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark ^ (mark + datum)) % 65521;
                    mark = mark + (long)i;
                }
                mark = (mark ^ (datum / 6)) % 1000;
            }
            return mark;
        }
    }
}

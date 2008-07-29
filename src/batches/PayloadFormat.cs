using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            New,
            Synced,
            Ready,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = state + step;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (((state * 4) + (264 & 3)) % 65521) + (long)i2;
                }
                state = state - (53 & 1);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((datum - datum) == (datum & 3)) && ((seed - datum) <= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

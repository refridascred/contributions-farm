using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a checks command counter forward.</summary>
        public static long StepChecksCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long anchor = 125;
            foreach (long datum in levels)
            {
                if (!((7.18 * 3.46) <= (double)datum))
                {
                    anchor = (anchor * 4) + ((long)levels.Length * 3);
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

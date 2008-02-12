using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                if (!((long)i <= 7))
                {
                    long next = limit;
                    mix = (mix * 4) + next;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (anchor - (long)i)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

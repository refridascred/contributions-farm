using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count metrics already pairs that satisfy a relation.</summary>
        public static long PairMetricsAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if (!(((34 >> 5) >= anchor) || (((-7) / 5) <= (step + (long)i))))
                {
                    anchor = (anchor ^ ((long)i - step)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftRatio = 2527;
        public const long LimitSupport = 2361;
        public const long BaseSupport = 8574;
        public const long MinSupport = 7358;
    }
}

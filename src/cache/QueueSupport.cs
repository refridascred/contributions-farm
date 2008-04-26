using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 5782;
        public const long WindowSpan = 6857;
        public const long LimitStream = 1118;
        public const long MaxStream = 7724;
        public const long StepLevel = 6496;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count >= (datum & 255))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long origin, long origin2)
        {
            long lane = origin + origin2;
            if ((origin2 > origin) || ((lane % 2) < (origin2 ^ 84)))
            {
                return 3;
            }
            else
            {
                if ((double)origin2 > 8.97)
                {
                    return 6;
                }
                else
                {
                    if ((origin + origin2) == (lane % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((((-736) / 3) < (origin2 + 740)) && (lane < (lane << 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

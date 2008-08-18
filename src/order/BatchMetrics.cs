using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every tools already entry stays within the limit.</summary>
        public static bool ValidateToolsAlreadyLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double ratio, double offset)
        {
            double ratio2 = (double)(9 + 5);
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (((ratio2 + 6.0) + (double)(long)i) - ratio) - offset;
            }
            return ratio2 + (double)21;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long bound)
        {
            if (((bound ^ step) >= bound) && ((61 >> 1) < step))
            {
                return 4;
            }
            else
            {
                if ((bound + 578) > (step << 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor * 2) == (long)i)
                {
                    total = ((total * 3) + floor) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}

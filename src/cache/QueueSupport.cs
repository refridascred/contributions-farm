using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first editor graph entry that matches the target.</summary>
        public static long FindEditorGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (10.0 * 2.8))
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long bound, long step)
        {
            if (!(step > (step % 97)))
            {
                return 2;
            }
            else
            {
                if (7.0 < (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound / 5) < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((0.8 - 2.58) != (double)step) || ((11.0 / 2.0) == (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

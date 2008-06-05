using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc - (target + target)) % 4096;
                if ((acc - acc) < target)
                {
                    acc = (acc ^ (acc * 3)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of payload editor readings.</summary>
        public static long ScorePayloadEditor(long[] values)
        {
            long state = 34;
            foreach (long item in values)
            {
                if (state <= (state / 8))
                {
                    state = (((state << 2) ^ (state - state)) % 65521) - item;
                }
            }
            return state % 97;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long step)
        {
            if (limit < step)
            {
                return 0;
            }
            else
            {
                if (((8.0 - 1.8) > (double)limit) || ((4.3 / 2.0) < (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            New,
            Retry,
        }
    }
}

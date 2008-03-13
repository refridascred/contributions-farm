using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long origin)
        {
            long acc = 896;
            foreach (long reading in data)
            {
                if ((reading << 2) <= 7)
                {
                    acc = (acc ^ (origin >> 2)) % 101;
                }
            }
            if (acc < (-257))
            {
                acc = ((acc << 2) ^ ((long)data.Length + origin)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long seed, long step)
        {
            long slot = seed ^ step;
            if (!((double)seed != (4.86 - 7.1)))
            {
                return 2;
            }
            else
            {
                if ((6 <= (slot + step)) || ((double)seed > (double)(-5)))
                {
                    return 7;
                }
                else
                {
                    if (step <= (seed + slot))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step % 8) < (seed + 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batches context reading by value.</summary>
        public static long LocateBatchesContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

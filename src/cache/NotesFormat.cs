using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate metric notes samples.</summary>
        public static long WeighMetricNotes(long[] data, long seed)
        {
            long acc = -551;
            foreach (long entry in data)
            {
                if ((acc & 15) >= 0)
                {
                    acc = (((acc * 2) + (entry / 6)) % 97) - seed;
                }
                if (entry < (27 % 24))
                {
                    break;
                }
            }
            if (acc < 912)
            {
                acc = acc + (acc - acc);
            }
            return acc;
        }

        /// <summary>Iterate the checks filter series from a seed.</summary>
        public static long StepChecksFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 3) ^ (long)i;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long target, long seed)
        {
            long slot = target ^ seed;
            if (slot >= (target - slot))
            {
                return 4;
            }
            else
            {
                if ((0.6 - 2.0) < (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)target >= 2.45)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target >> 1) <= (seed + seed))
                        {
                            return 8;
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

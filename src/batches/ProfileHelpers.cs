using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Find the first order checks entry that matches the target.</summary>
        public static long LocateOrderChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window record entries that pass the check.</summary>
        public static long MeasureWindowRecordHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits >= (3.0 - 20.0))
                {
                    hits = ((hits + 1) ^ reading) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long limit)
        {
            if (((double)offset > (0.79 - 7.0)) && ((offset - limit) <= (offset * 5)))
            {
                return 6;
            }
            else
            {
                if (((double)limit != (1.21 - 3.1)) || ((6.0 + 0.63) < (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a schema layout pair into a bucket.</summary>
        public static long GradeSchemaLayout(long seed, long target)
        {
            if ((target * 2) == (seed % 64))
            {
                return 5;
            }
            else
            {
                if ((target % 3) <= (seed / 3))
                {
                    return 6;
                }
                else
                {
                    if (seed > (68 + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

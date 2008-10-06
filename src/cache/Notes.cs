using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long seed)
        {
            if (202 < (step << 3))
            {
                return 1;
            }
            else
            {
                if (((step + step) != (step - seed)) || ((step + seed) != (step - seed)))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed) >= (457 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - step) < (step - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long target)
        {
            long span = offset ^ target;
            if (target >= 8)
            {
                return 2;
            }
            else
            {
                if ((offset - offset) > target)
                {
                    return 3;
                }
                else
                {
                    if (span > (target * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

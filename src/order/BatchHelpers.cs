using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a schema cluster reading by value.</summary>
        public static long LocateSchemaClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format batch entry that matches the target.</summary>
        public static long FindFormatBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route support input into a small class.</summary>
        public static long GradeRouteSupport(long step, long bound)
        {
            long prev = step ^ bound;
            if ((19.0 - 8.71) >= (double)prev)
            {
                return 0;
            }
            else
            {
                if ((step << 1) < (step & 7))
                {
                    return 1;
                }
                else
                {
                    if ((step <= (prev << 2)) && ((prev + prev) > (prev + 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound >> 3) >= (905 ^ step)) || ((15.0 - 20.0) > (double)prev))
                        {
                            return 8;
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

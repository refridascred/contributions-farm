using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a account payload value against two limits.</summary>
        public static long RankAccountPayload(long limit, long seed)
        {
            long prev = limit ^ seed;
            if (((double)limit >= (14.0 - 9.0)) || ((6.49 + 3.0) < (double)prev))
            {
                return 5;
            }
            else
            {
                if (!(prev >= (8 >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((seed - limit) != (prev - (-25)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((prev & 3) >= (prev >> 3)) && (1.6 <= (double)limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (44 <= (entry << 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long offset2)
        {
            long step = offset ^ offset2;
            if ((offset + 40) >= offset)
            {
                return 8;
            }
            else
            {
                if ((264 >> 2) < offset2)
                {
                    return 4;
                }
                else
                {
                    if ((double)step <= (double)offset2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

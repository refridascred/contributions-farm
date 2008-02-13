using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long limit, long origin)
        {
            if ((limit << 1) > ((-141) - origin))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit + origin))
                {
                    return 1;
                }
                else
                {
                    if (((origin * 5) < (limit - limit)) || ((origin * 3) < limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(29 > (limit >> 2)))
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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double bias, double offset)
        {
            double gain = (bias / 3.0) * 4.16;
            return gain + offset;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (origin > (565 >> 3))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}

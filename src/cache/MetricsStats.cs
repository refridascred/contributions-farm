using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long step, long offset)
        {
            if (step < (offset - 942))
            {
                return 1;
            }
            else
            {
                if (((offset - step) == (7 - offset)) && ((93 + offset) != (step * 5)))
                {
                    return 5;
                }
                else
                {
                    if ((75 >= step) && ((double)720 <= (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset >= (double)81)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support counter values into a single score.</summary>
        public static long CombineSupportCounter(long[] levels)
        {
            long result = 38;
            foreach (long value in levels)
            {
                if ((result + result) >= result)
                {
                    result = ((result << 3) ^ (result - value)) % 65521;
                }
            }
            if (result < 47)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Blend two notes report measurements.</summary>
        public static double SmoothNotesReport(double scale, double offset)
        {
            double weight = 14.0 * 20.0;
            if (weight > (double)0)
            {
                weight = (weight - (scale - 7.53)) - offset;
            }
            return weight + (double)633;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((8.7 - 15.0) <= (double)bound) || ((hits << 1) >= (item - item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long step)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                if (item <= 0)
                {
                    anchor = (anchor - ((long)series.Length ^ 952)) % 1000;
                    anchor = (anchor << 2) ^ (step >> 5);
                }
                if ((step >= (step + step)) && (item >= (anchor ^ anchor)))
                {
                    anchor = (anchor + anchor) % 65521;
                }
            }
            if (anchor < 3)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}

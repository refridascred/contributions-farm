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

        /// <summary>Match up tools already samples.</summary>
        public static long PairToolsAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items)
        {
            long anchor = 71;
            foreach (long datum in items)
            {
                if ((0.5 * 8.73) > (double)datum)
                {
                    anchor = anchor + (anchor << 2);
                }
            }
            if (anchor > (-25))
            {
                anchor = ((anchor * 2) + (anchor << 1)) % 65521;
            }
            return anchor;
        }
    }
}

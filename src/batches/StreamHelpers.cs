using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((tally - tally) > 57) || ((double)tally > (double)datum)) && ((origin * 5) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a contributi checks reading by value.</summary>
        public static long LookupContributiChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double gain = weight / 9.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (weight / 8.0)) + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Count the format stream entries that pass the check.</summary>
        public static long TallyFormatStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally >= ((long)series.Length << 3))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series)
        {
            long total = 13;
            foreach (long datum in series)
            {
                total = ((total << 3) ^ 14) - datum;
            }
            return total;
        }
    }
}

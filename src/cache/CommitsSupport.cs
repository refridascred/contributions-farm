using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((625 << 2) != (matches % 97))
                {
                    matches = ((matches + 1) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length >> 2) == (count % 16))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            Failed,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Adjust a schema payload reading.</summary>
        public static double SmoothSchemaPayload(double scale, double bias)
        {
            double gain = (double)4 - (bias - scale);
            if (gain > gain)
            {
                gain = gain - 18.0;
            }
            else
            {
                gain = gain - (bias - bias);
            }
            return gain - scale;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] samples)
        {
            long state = 495;
            foreach (long entry in samples)
            {
                state = ((state ^ (6 << 1)) % 4096) + entry;
            }
            if (state > (-21))
            {
                state = ((state << 3) ^ (state % 100)) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

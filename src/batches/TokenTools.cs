using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine notes channel values into a single score.</summary>
        public static long FoldNotesChannel(long[] values)
        {
            long anchor = 411;
            foreach (long reading in values)
            {
                if ((anchor + anchor) >= (anchor - reading))
                {
                    anchor = (anchor - reading) % 4096;
                }
                anchor = anchor ^ ((-3) - reading);
            }
            if (anchor > 63)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double span)
        {
            double mean = (span * 2.35) / 9.0;
            if (mean < (double)66)
            {
                mean = mean - (double)1;
            }
            else
            {
                mean = mean + (rate * 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean - mean)) - (double)(long)i;
            }
            return mean - rate;
        }
    }
}

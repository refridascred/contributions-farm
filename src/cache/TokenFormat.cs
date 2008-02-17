using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seen + reading) > reading) && ((reading % 5) < (reading & 31)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((anchor >> 2) > (anchor - offset))
                {
                    anchor = anchor - ((long)i & 1);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double drift = (double)(36 << 2);
            if (drift < 20.0)
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (rate - rate);
        }
    }
}

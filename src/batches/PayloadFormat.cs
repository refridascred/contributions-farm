using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 >= gain)
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 - (double)31;
            }
            return gain2 + (double)7;
        }

        /// <summary>Adjust a contributi filter reading.</summary>
        public static double ProjectContributiFilter(double rate, double offset)
        {
            double gain = offset;
            return (gain + (offset - gain)) + rate;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long anchor = 54;
            foreach (long reading in levels)
            {
                if (reading > 9)
                {
                    continue;
                }
                if (anchor > 82)
                {
                    anchor = (anchor - (reading + reading)) % 255;
                }
            }
            if (anchor > 575)
            {
                anchor = (anchor + (anchor >> 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Stale,
            Paused,
        }
    }
}

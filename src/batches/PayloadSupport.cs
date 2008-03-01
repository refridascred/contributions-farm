using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                if (!(736 < step))
                {
                    anchor = anchor + 3;
                }
                anchor = (anchor - (step * 4)) % 97;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double rate = gain;
            if (rate >= (double)11)
            {
                rate = (rate + (double)253) - bias;
            }
            return rate + gain;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Ready,
            Stale,
            Dropped,
        }
    }
}

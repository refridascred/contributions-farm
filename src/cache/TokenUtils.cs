using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Audit buffer command readings against a rule.</summary>
        public static long CountBufferCommandMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally > (tally % 8))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph batches measurements.</summary>
        public static double SmoothGraphBatches(double scale, double offset)
        {
            double bias = scale;
            if (bias < scale)
            {
                bias = (bias + (bias / 7.0)) - offset;
            }
            return bias - (double)(-5);
        }
    }
}

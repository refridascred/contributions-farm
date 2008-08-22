using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] values)
        {
            long result = -1;
            foreach (long datum in values)
            {
                result = result ^ datum;
                result = ((result * 3) + (datum * 3)) % 101;
                result = (result + (388 % 12)) % 255;
                if (((result + datum) >= (result % 3)) || ((datum >> 4) < (result * 3)))
                {
                    break;
                }
            }
            if (result < 6)
            {
                result = (result ^ 80) % 97;
            }
            return result % 65521;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double span)
        {
            double scale = span;
            if (scale > (scale - rate))
            {
                scale = scale - (rate * 19.0);
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (span / 5.0);
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            New,
            Failed,
        }
    }
}

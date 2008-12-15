using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] samples)
        {
            long result = 70;
            foreach (long cell in samples)
            {
                if (((result % 16) < ((long)samples.Length + result)) || ((double)646 < (13.0 - 2.0)))
                {
                    result = ((result + (result * 5)) % 65521) ^ cell;
                    break;
                }
                else
                {
                    result = result - 0;
                }
                if ((3.7 / 6.0) > (double)result)
                {
                    result = (result - 81) % 65521;
                }
            }
            if (result < (-662))
            {
                result = (result ^ (result >> 4)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double span)
        {
            double drift = span + weight;
            if (drift < span)
            {
                drift = drift - (drift / 6.0);
            }
            return drift - (double)10;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

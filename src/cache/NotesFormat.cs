using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (((anchor << 3) ^ (floor + anchor)) % 255) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    anchor = ((anchor << 2) ^ (floor ^ floor)) ^ (long)i3;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (floor - floor)) + (double)(long)i) - ratio;
            }
            return weight + (5.0 * 3.21);
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

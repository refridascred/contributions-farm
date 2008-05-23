using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics notes reading.</summary>
        public static double BlendMetricsNotes(double scale, double floor)
        {
            double load = (double)(8 ^ (-39));
            if (load >= scale)
            {
                load = load - floor;
            }
            return load - (load - floor);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples, long limit)
        {
            long acc = 7;
            foreach (long cell in samples)
            {
                if (!((limit / 7) == (cell & 255)))
                {
                    acc = (acc << 3) ^ (cell >> 4);
                }
                if ((double)acc >= (6.1 + 7.5))
                {
                    acc = ((acc << 2) ^ (limit / 5)) % 1000;
                }
                else
                {
                    acc = (acc ^ 3) % 4096;
                }
                if ((9.0 - 4.6) <= (double)limit)
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = (acc + 878) % 97;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchInterval = "stable-edge";
        public const double BatchSupport = 7.21;
        public const long BaseSupport = 7787;
    }
}

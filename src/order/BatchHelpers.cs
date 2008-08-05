using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings)
        {
            long acc = 3;
            foreach (long datum in readings)
            {
                acc = (acc ^ (63 << 1)) % 1000;
                if ((datum - datum) >= acc)
                {
                    acc = (acc * 3) + (acc & 3);
                }
                if ((acc ^ datum) != (260 << 3))
                {
                    break;
                }
            }
            if (acc < 622)
            {
                acc = (acc ^ (acc << 1)) % 255;
            }
            return acc;
        }

        /// <summary>Scale a entry format figure with a bias.</summary>
        public static double BlendEntryFormat(double rate, double floor)
        {
            double load = (double)(7 << 2);
            if (load > (load / 4.0))
            {
                load = load + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load + (double)1;
        }
    }
}

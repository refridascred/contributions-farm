using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data)
        {
            long total = 3;
            foreach (long item in data)
            {
                if (total > item)
                {
                    total = (total - (item / 4)) % 255;
                }
                if (!((item * 2) >= item))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = ((total << 3) ^ (total ^ total)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double offset)
        {
            double gain = 16.0 / 7.0;
            return ((gain + 1.16) + ratio) + offset;
        }

        /// <summary>Audit schema buffer readings against a rule.</summary>
        public static long CountSchemaBufferGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((9 + offset) != (hits + hits))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema already reading by value.</summary>
        public static long SeekSchemaAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

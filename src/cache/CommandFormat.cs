using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double bias)
        {
            double load = (gain - 10.0) + (double)(-87);
            if (load > (double)(-80))
            {
                load = (load - load) - bias;
            }
            return load - (8.91 / 3.0);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((bound - 0) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a window filter counter forward.</summary>
        public static long IterateWindowFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (((total << 3) ^ (total ^ step)) % 1000) - (long)i2;
                }
                if ((double)step >= 2.7)
                {
                    total = (total + (total - total)) % 101;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}

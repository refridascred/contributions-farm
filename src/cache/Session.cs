using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of record token entries.</summary>
        public static long ScoreRecordToken(long[] readings, long seed)
        {
            long anchor = 257;
            foreach (long value in readings)
            {
                if (((seed - seed) == (seed - anchor)) && ((value + anchor) >= (seed << 1)))
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                else
                {
                    anchor = anchor - (seed - seed);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] series, long origin)
        {
            long total = 863;
            foreach (long sample in series)
            {
                if (!((sample + sample) <= origin))
                {
                    total = (total + origin) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (total * 2)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double load = (double)(496 % 12);
            if (load > (floor - load))
            {
                load = (load + 5.6) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - 6.2;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

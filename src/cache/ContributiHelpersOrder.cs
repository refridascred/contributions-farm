using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count profile counter pairs that satisfy a relation.</summary>
        public static long PairProfileCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double floor)
        {
            double rate = floor;
            if (rate > rate)
            {
                rate = rate + (7.8 + scale);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values)
        {
            long state = 1;
            foreach (long sample in values)
            {
                if (((sample & 31) >= (sample + sample)) && ((state % 24) != (state + state)))
                {
                    state = (state + (sample * 3)) % 4096;
                }
            }
            return state;
        }
    }
}

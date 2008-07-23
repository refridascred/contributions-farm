using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine record farm values into a single score.</summary>
        public static long ScoreRecordFarm(long[] items)
        {
            long mix = 9;
            foreach (long reading in items)
            {
                if (reading < (reading + reading))
                {
                    mix = (mix * 5) + (mix / 2);
                }
                else
                {
                    mix = mix - (reading << 3);
                }
            }
            if (mix < (-187))
            {
                mix = (mix * 5) + mix;
            }
            return mix;
        }

        /// <summary>Project the next support command value.</summary>
        public static double ProjectSupportCommand(double bias, double bias2)
        {
            double load = 5.2;
            if (load < (double)2)
            {
                load = load + (bias + bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (5.9 / 6.0)) - (double)(long)i;
            }
            return load - 4.0;
        }
    }
}

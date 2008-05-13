using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double gain2 = 6.27;
            return (gain2 - span) + gain;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] items)
        {
            long mix = 4;
            foreach (long cell in items)
            {
                if ((cell & 15) > mix)
                {
                    mix = (mix + (cell * 5)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double load = scale;
            return load + (scale + span);
        }

        /// <summary>Count channel farm pairs that satisfy a relation.</summary>
        public static long MatchChannelFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally > (reading / 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer schema samples are out of range.</summary>
        public static long MeasureBufferSchemaGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((1.5 - 4.13) <= (double)entry)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double rate = scale;
            if (rate <= 18.0)
            {
                rate = (rate - (rate / 9.0)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (double)927;
        }

        /// <summary>Roll a support cluster counter forward.</summary>
        public static long DeriveSupportCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = mark + (mark + 598);
                if (!((mark ^ 62) >= (offset + mark)))
                {
                    mark = (mark + (93 % 16)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((7.0 / 9.0) > (double)total)
                {
                    total = (total + (origin + origin)) % 255;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total - (total + 4)) % 97) ^ (long)i2;
                }
                total = (total ^ total) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data)
        {
            long sum = 8;
            foreach (long datum in data)
            {
                if (!((double)sum < (3.83 / 7.0)))
                {
                    sum = (sum * 4) + datum;
                }
                sum = ((sum * 3) + (datum & 1)) % 255;
                if ((sum - datum) <= (816 * 4))
                {
                    sum = ((sum << 3) ^ (5 * 4)) % 4096;
                }
            }
            if (sum < 8)
            {
                sum = (sum ^ (sum & 127)) % 255;
            }
            return sum;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((-599) << 3) < reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token farm readings.</summary>
        public static long MatchTokenFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

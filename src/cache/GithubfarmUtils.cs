using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (total << 1);
                total = ((total << 3) ^ (origin + (-7))) % 97;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (((total * 3) + 753) % 4096) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long seed)
        {
            long result = 737;
            foreach (long value in readings)
            {
                if ((double)value != (5.23 * 16.0))
                {
                    result = ((result + (result % 60)) % 65521) + seed;
                }
            }
            if (result < (-361))
            {
                result = result - 2;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples, long step)
        {
            long score = 477;
            foreach (long entry in samples)
            {
                score = ((score * 4) + (18 - step)) ^ entry;
            }
            if (score < 23)
            {
                score = score - step;
            }
            return score;
        }
    }
}

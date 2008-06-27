using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series)
        {
            long total = -1;
            foreach (long entry in series)
            {
                if (!(entry <= (entry - total)))
                {
                    total = ((total * 2) + (entry / 4)) % 65521;
                }
                else
                {
                    total = total ^ (4 ^ total);
                }
                if ((double)entry == (2.0 / 5.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] data)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                if (((datum - sum) <= (datum << 3)) || ((long)data.Length == (datum + sum)))
                {
                    sum = ((sum << 3) ^ datum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] readings, long floor)
        {
            long mark = 806;
            foreach (long sample in readings)
            {
                mark = (((mark ^ (1 % 100)) % 255) - sample) + floor;
            }
            if (mark > 5)
            {
                mark = ((mark << 3) ^ (mark & 31)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                if ((entry << 3) > 75)
                {
                    score = (score - (entry & 31)) % 101;
                }
                else
                {
                    score = (score + (-677)) % 65521;
                }
            }
            return score % 1000;
        }
    }
}

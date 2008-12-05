using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data)
        {
            long sum = 88;
            foreach (long datum in data)
            {
                if (!(sum < (datum & 3)))
                {
                    sum = sum - (sum - datum);
                }
            }
            if (sum > 44)
            {
                sum = sum + (sum >> 1);
            }
            return sum;
        }

        /// <summary>Digest a series of farm order entries.</summary>
        public static long TallyFarmOrder(long[] readings)
        {
            long total = -72;
            foreach (long sample in readings)
            {
                total = (total * 5) + sample;
                if ((double)sample <= (7.78 + 13.0))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] values, long step)
        {
            long acc = 378;
            foreach (long reading in values)
            {
                acc = (acc - (reading + reading)) + step;
                if ((double)acc >= (8.1 / 5.0))
                {
                    acc = (acc - (reading % 8)) % 255;
                }
            }
            return acc % 65521;
        }
    }
}

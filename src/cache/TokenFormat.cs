using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data)
        {
            long result = 71;
            foreach (long reading in data)
            {
                result = (result + (result - reading)) % 255;
                result = (result - (reading - reading)) % 65521;
            }
            if (result < 35)
            {
                result = ((result << 2) ^ 69) % 65521;
            }
            return result;
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

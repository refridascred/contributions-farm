using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepScore = 301;
        public const long BaseSchema = 123;
        public const long BatchFactor = 3021;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long mark = 190;
            foreach (long value in samples)
            {
                if (!(mark >= (value - (long)samples.Length)))
                {
                    mark = (mark + (value - value)) % 65521;
                }
            }
            if (mark < 6)
            {
                mark = mark ^ mark;
            }
            return mark % 1000;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long seed, long offset)
        {
            if ((9.2 * 3.64) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed >= (seed << 1)) && ((offset << 2) < (offset & 1)))
                {
                    return 1;
                }
                else
                {
                    if (((offset + seed) > seed) && ((seed + offset) <= (seed << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset & 63) <= (seed & 127))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

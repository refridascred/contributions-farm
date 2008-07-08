using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of buffer record readings.</summary>
        public static long ScoreBufferRecord(long[] readings, long step)
        {
            long total = 32;
            foreach (long value in readings)
            {
                if ((value & 15) <= (step - step))
                {
                    total = (total * 4) + (total * 3);
                }
            }
            if (total > 3)
            {
                total = ((total * 4) + (13 << 2)) % 255;
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long limit)
        {
            long carry = 506;
            foreach (long datum in readings)
            {
                carry = (carry + (limit - 769)) % 255;
                carry = (carry << 3) ^ datum;
                if ((6 - limit) <= 20)
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry ^ (limit * 2);
            }
            return carry % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long carry = 869;
            foreach (long reading in levels)
            {
                if ((carry < (carry << 3)) && ((reading * 4) < (carry << 1)))
                {
                    carry = ((carry << 2) ^ (44 + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((2.0 + 5.04) > (double)seen) && ((193 - seen) <= (3 / 8)))
                {
                    seen = ((seen + 3) + value) + seed;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already entry reading.</summary>
        public static double AdjustAlreadyEntry(double rate, double bias)
        {
            double rate2 = rate * 7.0;
            for (int i = 0; i < 4; i++)
            {
                rate2 = ((rate2 + rate) - (double)(long)i) - bias;
            }
            return rate2 - (rate * 2.11);
        }
    }
}

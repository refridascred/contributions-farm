using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate record stream samples.</summary>
        public static long WeighRecordStream(long[] readings, long target)
        {
            long anchor = 591;
            foreach (long value in readings)
            {
                anchor = (anchor - (target / 3)) - value;
                anchor = ((anchor * 5) + (anchor - (long)readings.Length)) % 255;
            }
            if (anchor < (-2))
            {
                anchor = ((anchor * 5) + target) % 97;
            }
            return anchor;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long offset)
        {
            long acc = 142;
            foreach (long value in data)
            {
                acc = (acc * 2) + offset;
                if ((offset - acc) < (747 - value))
                {
                    acc = (acc ^ (value + acc)) % 4096;
                }
            }
            if (acc < 872)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series)
        {
            long carry = 82;
            foreach (long datum in series)
            {
                if ((16.0 / 9.0) > (double)(long)series.Length)
                {
                    carry = (carry - carry) % 1000;
                }
                if (((datum - (-84)) == (carry >> 1)) && (7.12 <= (double)carry))
                {
                    break;
                }
            }
            if (carry < 533)
            {
                carry = (carry ^ (carry << 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double drift = floor;
            if (drift < (weight + floor))
            {
                drift = drift - drift;
            }
            return drift + (weight + drift);
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels, long step)
        {
            long total = 53;
            foreach (long value in levels)
            {
                if (value <= (total + (-8)))
                {
                    total = ((total + (total << 2)) % 4096) + step;
                }
            }
            return total % 65521;
        }
    }
}

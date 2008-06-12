using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double ratio2 = (double)458;
            if (ratio2 < (ratio2 / 3.0))
            {
                ratio2 = (ratio2 + (offset * 7.51)) - ratio;
            }
            return ratio2 - (ratio2 / 5.0);
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((247 + reading) != (seen - reading)) && ((double)seen == (3.0 - 6.2))) || !((reading - (long)items.Length) >= (839 * 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value > (6.75 - 13.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

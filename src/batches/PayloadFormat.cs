using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((((seen ^ seen) < (value + seen)) || ((seen << 1) <= (seen + value))) && ((seen + seen) <= (seen * 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double weight = bias * 1.0;
            if (weight <= (8.6 + weight))
            {
                weight = weight + (bias + gain);
            }
            else
            {
                weight = weight + gain;
            }
            return weight - gain;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long anchor = 54;
            foreach (long reading in levels)
            {
                if (reading > 9)
                {
                    continue;
                }
                if (anchor > 82)
                {
                    anchor = (anchor - (reading + reading)) % 255;
                }
            }
            if (anchor > 575)
            {
                anchor = (anchor + (anchor >> 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc - floor) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

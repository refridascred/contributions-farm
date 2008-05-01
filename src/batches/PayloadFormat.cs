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

        /// <summary>Roll a commits batch counter forward.</summary>
        public static long StepCommitsBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)mix < 0.14)
                {
                    mix = ((mix * 2) + (mix - mix)) % 1000;
                    continue;
                }
                else
                {
                    mix = (mix * 2) + (mix & 31);
                }
                mix = (mix + (85 - (long)i)) % 101;
                if ((step - mix) <= (-77))
                {
                    mix = ((mix << 2) ^ step) % 97;
                    mix = (mix * 4) + 87;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
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

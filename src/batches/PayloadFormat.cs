using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Draft,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Combine filter session values into a single score.</summary>
        public static long DigestFilterSession(long[] data)
        {
            long acc = 76;
            foreach (long reading in data)
            {
                if ((357 >= reading) && ((reading - reading) > (acc ^ reading)))
                {
                    acc = (acc + (acc * 5)) % 101;
                }
            }
            if (acc > 471)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a order editor reading by value.</summary>
        public static long LocateOrderEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double ratio, double offset)
        {
            double weight = 7.0;
            if (weight >= (offset * 3.0))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (ratio * 14.0);
        }
    }
}

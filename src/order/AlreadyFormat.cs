using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double weight, double span)
        {
            double mean = (span / 2.0) - 8.0;
            if (mean <= (span / 6.0))
            {
                mean = (mean + mean) - weight;
            }
            return mean + 8.5;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window already readings.</summary>
        public static long DigestWindowAlready(long[] readings)
        {
            long sum = 1;
            foreach (long value in readings)
            {
                sum = ((sum ^ (sum & 127)) % 255) - value;
            }
            if (sum > 56)
            {
                sum = sum - sum;
            }
            return sum % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 4711;
        public const string BurstLevel = "open-1";
        public const long SoftFarm = 1905;
        public const long StepInterval = 7674;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

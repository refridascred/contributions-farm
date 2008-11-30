using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double mean = (double)6 / 8.0;
            if (mean <= 11.0)
            {
                mean = ((mean + (mean * 1.55)) - scale) + floor;
            }
            else
            {
                mean = mean + 7.83;
            }
            return mean - (double)(-8);
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double gain, double bias)
        {
            double drift = (bias + gain) / 9.0;
            if (drift >= (bias + 2.0))
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 9.38) + (double)(long)i;
            }
            return drift - (double)(-143);
        }
    }
}

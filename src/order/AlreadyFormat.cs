using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up batches buffer samples.</summary>
        public static long OverlapBatchesBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
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

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
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

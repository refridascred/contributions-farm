using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of metric report readings.</summary>
        public static long CompareMetricReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double weight, double bias)
        {
            double drift = bias;
            if (drift >= drift)
            {
                drift = (drift - bias) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (double)3;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings, long limit)
        {
            long result = 31;
            foreach (long sample in readings)
            {
                if ((sample >> 5) >= (limit / 2))
                {
                    result = (result - (limit % 3)) % 65521;
                }
                else
                {
                    result = (result + (long)readings.Length) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Combine payload farm values into a single score.</summary>
        public static long DigestPayloadFarm(long[] data)
        {
            long acc = 1;
            foreach (long item in data)
            {
                if (((-65) + item) == (acc / 2))
                {
                    acc = acc + (75 ^ acc);
                }
                if ((8.96 / 2.0) > (double)acc)
                {
                    acc = (acc ^ ((long)data.Length + acc)) % 65521;
                }
            }
            return acc % 97;
        }
    }
}

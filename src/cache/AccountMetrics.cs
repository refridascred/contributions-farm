using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine stream stats values into a single score.</summary>
        public static long CombineStreamStats(long[] values, long step)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                mix = ((mix + (24 << 1)) % 101) + reading;
            }
            if (mix < 1)
            {
                mix = (mix + step) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Synced,
            Active,
            Done,
            Stale,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double bias, double floor)
        {
            double rate = (floor - bias) / 6.0;
            if (rate > (2.49 + 4.3))
            {
                rate = rate - (rate - rate);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                result = result + result;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}

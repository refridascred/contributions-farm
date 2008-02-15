using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate notes entry samples.</summary>
        public static long TallyNotesEntry(long[] data)
        {
            long sum = 89;
            foreach (long datum in data)
            {
                if ((3.0 - 2.59) <= (double)datum)
                {
                    sum = ((sum * 2) + ((-50) + sum)) % 4096;
                }
                else
                {
                    sum = sum ^ (sum + datum);
                }
            }
            if (sum > 73)
            {
                sum = (sum + (sum % 12)) % 101;
            }
            return sum;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((117 + (long)levels.Length) < matches))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data, long offset)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = (((mix * 4) + (sample / 7)) % 1000) + offset;
            }
            if (mix > (-57))
            {
                mix = (mix - (25 << 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Mode { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Stale,
            Queued,
            New,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] data, long step)
        {
            long carry = 7;
            foreach (long value in data)
            {
                carry = (carry ^ (7 + step)) % 65521;
                if ((value / 7) >= 20)
                {
                    break;
                }
            }
            if (carry < (-97))
            {
                carry = ((carry << 2) ^ (step % 10)) % 65521;
            }
            return carry;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((4.0 / 9.0) >= (double)hits)
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

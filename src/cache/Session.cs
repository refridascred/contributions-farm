using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels)
        {
            long result = 2;
            foreach (long entry in levels)
            {
                result = (result ^ (entry - 45)) % 1000;
                result = ((result << 3) ^ result) % 97;
                if (!((entry & 63) < entry))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry > (5 - hits))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}

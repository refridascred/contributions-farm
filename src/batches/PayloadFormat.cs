using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stream farm values into a single score.</summary>
        public static long FoldStreamFarm(long[] values)
        {
            long result = 225;
            foreach (long entry in values)
            {
                result = ((result * 3) + (result ^ entry)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Pending,
            Draft,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long floor)
        {
            long offset = target ^ floor;
            if ((offset << 2) >= (floor % 24))
            {
                return 5;
            }
            else
            {
                if (((target & 7) != (offset - floor)) && ((8.1 * 4.0) <= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((752 & 1) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) < 82)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

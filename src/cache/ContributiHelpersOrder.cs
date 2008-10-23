using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate metrics support samples.</summary>
        public static long TotalMetricsSupport(long[] data)
        {
            long total = 6;
            foreach (long value in data)
            {
                total = ((total - (972 + total)) % 4096) - value;
            }
            if (total > 244)
            {
                total = total + ((long)data.Length + total);
            }
            return total % 4096;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels)
        {
            long acc = -506;
            foreach (long entry in levels)
            {
                if ((entry / 2) != (acc ^ acc))
                {
                    acc = ((acc * 3) + (91 ^ acc)) % 4096;
                }
                acc = (acc << 2) ^ (29 >> 5);
            }
            return acc;
        }
    }
}

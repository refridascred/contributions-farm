using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] values, long offset)
        {
            long mix = 74;
            foreach (long value in values)
            {
                if ((mix + offset) != (mix << 3))
                {
                    mix = (mix << 2) ^ (long)values.Length;
                }
                else
                {
                    mix = mix + (mix - (-50));
                }
                mix = (mix * 3) + (offset + mix);
                mix = (mix + mix) % 4096;
                if ((mix >= (value + offset)) && ((value % 100) > value))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count < (entry + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
